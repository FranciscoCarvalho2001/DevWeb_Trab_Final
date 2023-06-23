// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using DevWeb_Trab_Final.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DevWeb_Trab_Final.Areas.Identity.Pages.Account.Manage
{
    public class DeletePersonalDataModel : PageModel
    {
        private readonly UserManager<DevWeb_Trab_Final_User> _userManager;
        private readonly SignInManager<DevWeb_Trab_Final_User> _signInManager;
        private readonly ILogger<DeletePersonalDataModel> _logger;
        private readonly DevWeb_Trab_FinalContext _context;

        public DeletePersonalDataModel(
            UserManager<DevWeb_Trab_Final_User> userManager,
            SignInManager<DevWeb_Trab_Final_User> signInManager,
            ILogger<DeletePersonalDataModel> logger,
            DevWeb_Trab_FinalContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public bool RequirePassword { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            RequirePassword = await _userManager.HasPasswordAsync(user);
            if (RequirePassword)
            {
                if (!await _userManager.CheckPasswordAsync(user, Input.Password))
                {
                    ModelState.AddModelError(string.Empty, "Incorrect password.");
                    return Page();
                }
            }

            // começa transação para apagar da tabela Funcionarios ou Clientes
            using (var transacao = await _context.Database.BeginTransactionAsync()) {

                try {

                    var result = await _userManager.DeleteAsync(user);
                    var userId = await _userManager.GetUserIdAsync(user);
                    if (!result.Succeeded) {
                        throw new InvalidOperationException($"Unexpected error occurred deleting user.");
                    }

                    // vai buscar o ID do funcionario
                    var funcionario = await _context.Funcionarios.SingleOrDefaultAsync(f => f.UserId == userId);
                    // vai buscar o ID do cliente
                    var cliente = await _context.Clientes.SingleOrDefaultAsync(c => c.UserId == userId);

                    if (funcionario != null) {
                        // apaga da tabela Funcionarios
                        _context.Funcionarios.Remove(funcionario);
                    }
                    if (cliente != null) {
                        // apaga da tabela Clientes
                        _context.Clientes.Remove(cliente);
                    }

                    // guarda as mudanças na DB
                    await _context.SaveChangesAsync();
                    // faz Commit da transação
                    await transacao.CommitAsync();

                    await _signInManager.SignOutAsync();

                    _logger.LogInformation("User with ID '{UserId}' deleted themselves.", userId);

                    return Redirect("~/");

                } catch (Exception) {

                    // se correu mal a transação, faz rollback
                    await transacao.RollbackAsync();
                    throw;
                
                }
            }
        }
    }
}
