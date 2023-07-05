// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DevWeb_Trab_Final.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<DevWeb_Trab_Final_User> _userManager;
        private readonly SignInManager<DevWeb_Trab_Final_User> _signInManager;
        private readonly DevWeb_Trab_FinalContext _context;

        public IndexModel(
            UserManager<DevWeb_Trab_Final_User> userManager,
            SignInManager<DevWeb_Trab_Final_User> signInManager,
            DevWeb_Trab_FinalContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Referencia para a classe Clientes
        /// </summary>
        public Clientes Cliente { get; set; }

        /// <summary>
        /// Referencia para a classe Funcionarios
        /// </summary>
        public Funcionarios Funcionario { get; set; }

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
            [Display(Name = "Telemóvel")]
            [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter {1} digitos")]
            [RegularExpression("9[1236][0-9]{7}", ErrorMessage = "O número de {0} deve começar por 91, 92, 93 ou 96, e ter 9 dígitos")]
            public string PhoneNumber { get; set; }

            /// <summary>
            ///  Input da nova Morada
            /// </summary>
            public string Morada { get; set; }

            /// <summary>
            /// Input do novo Código Postal
            /// </summary>
            [Display(Name = "Código Postal")]
            [RegularExpression("[1-9][0-9]{3}-[0-9]{3} [A-ZÇÁÉÍÓÚÊÂÎÔÛÀÃÕ ]+", ErrorMessage = "O {0} tem de ser da forma XXXX-XXX NOME DA TERRA")]
            public string CodPostal { get; set; }
        }

        private async Task LoadAsync(DevWeb_Trab_Final_User user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            //Input = new InputModel
            //{
            //    PhoneNumber = phoneNumber
            //};

            // vai buscar valores Clientes do utilizador
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Email == user.Email);
            Cliente = cliente;
            // vai buscar valores Funcionarios do utilizador
            var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(f => f.Email == user.Email);
            Funcionario = funcionario;

            // não há condições para fazer check do Role, porque se utilizador for Cliente a var funcionario será null, e vice versa

        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            // obtem valores Clientes do utilizador
            var cliente = _context.Clientes.FirstOrDefault(c => c.Email == user.Email);
            // se for cliente...
            if (cliente != null) {
                // check para ver se houve mudança no Telemovel
                if (Input.PhoneNumber != null) {
                    // atualiza Telemovel do Cliente
                    cliente.Telemovel = Input.PhoneNumber;

                    // check para ver se houve mudança na Morada
                    if (Input.Morada != null) {
                        // atualiza Morada do Cliente
                        cliente.Morada = Input.Morada;

                        if (Input.CodPostal != null) {
                            // atualiza CodPostal do Cliente
                            cliente.CodPostal = Input.CodPostal;
                        }
                    }
                    if (Input.CodPostal != null) {
                        // atualiza CodPostal do Cliente
                        cliente.CodPostal = Input.CodPostal;
                    }
                }
                // check para ver se houve mudança na Morada
                if (Input.Morada != null) {
                    // atualiza Morada do Cliente
                    cliente.Morada = Input.Morada;

                    if (Input.CodPostal != null) {
                        // atualiza CodPostal do Cliente
                        cliente.CodPostal = Input.CodPostal;
                    }
                }
                // check para ver se houve mudança no Código Postal
                if (Input.CodPostal != null) {
                    // atualiza CodPostal do Cliente
                    cliente.CodPostal = Input.CodPostal;          
                }

                // check para ver se não houve nenhuma alteração
                if (Input.PhoneNumber == null && Input.Morada == null && Input.CodPostal == null) {
                    StatusMessage = "Não forem feitas alterações.";
                } else {
                    // faz update á DB
                    _context.Clientes.Update(cliente);
                    await _context.SaveChangesAsync();
                    StatusMessage = "O seu Perfil foi atualizado.";
                }
            }

            // obtem valores Funcionarios do utilizador
            var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Email == user.Email);
            // se for funcionario...
            if (funcionario != null) {
                // check para ver se houve mudança no Telemovel
                if (Input.PhoneNumber != null) {
                    // atualiza Telemovel do Funcionario
                    funcionario.Telemovel = Input.PhoneNumber;

                    // check para ver se houve mudança na Morada
                    if (Input.Morada != null) {
                        // atualiza Morada do Funcionario
                        funcionario.Morada = Input.Morada;

                        if (Input.CodPostal != null) {
                            // atualiza CodPostal do Funcionario
                            funcionario.CodPostal = Input.CodPostal;
                        }
                    }
                    if (Input.CodPostal != null) {
                        // atualiza CodPostal do Funcionario
                        funcionario.CodPostal = Input.CodPostal;
                    }
                }
                // check para ver se houve mudança na Morada
                if (Input.Morada != null) {
                    // atualiza Morada do Funcionario
                    funcionario.Morada = Input.Morada;

                    if (Input.CodPostal != null) {
                        // atualiza CodPostal do Funcionario
                        funcionario.CodPostal = Input.CodPostal;
                    }
                }
                // check para ver se houve mudança no Código Postal
                if (Input.CodPostal != null) {
                    // atualiza CodPostal do Funcionario
                    funcionario.CodPostal = Input.CodPostal;
                }

                // check para ver se não houve nenhuma alteração
                if (Input.PhoneNumber == null && Input.Morada == null && Input.CodPostal == null) {
                    StatusMessage = "Não forem feitas alterações.";
                } else {
                    // faz update á DB
                    _context.Funcionarios.Update(funcionario);
                    await _context.SaveChangesAsync();
                    StatusMessage = "O seu Perfil foi atualizado.";
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            return RedirectToPage();
        }
    }
}
