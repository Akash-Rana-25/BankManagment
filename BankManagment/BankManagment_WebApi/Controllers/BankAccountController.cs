using AutoMapper;
using BankManagment_Domain.Entity;
using BankManagment_DTO;
using BankManagment_Services;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

[RoutePrefix("api/bankaccounts")]
    public class BankAccountController : Controller
{
        private readonly IBankAccountService _bankAccountService;
        private readonly IMapper _mapper;

        public BankAccountController(IBankAccountService bankAccountService, IMapper mapper)
        {
            _bankAccountService = bankAccountService;
            _mapper = mapper;
        }
        [Microsoft.AspNetCore.Mvc.HttpGet("bankaccounts")]
        public async Task<IActionResult> GetBankAccounts()
        {
            var bankAccounts = await _bankAccountService.GetAllBankAccountsAsync();
            var bankAccountDTOs = _mapper.Map<List<BankAccountDTO>>(bankAccounts);
            return Ok(bankAccountDTOs);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("bankaccounts")]
        public async Task<IActionResult> CreateBankAccount([Microsoft.AspNetCore.Mvc.FromBody] BankAccountDTO bankAccountDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var bankAccount = _mapper.Map<BankAccount>(bankAccountDTO);

            await _bankAccountService.CreateBankAccountAsync(bankAccount);
            await _bankAccountService.SaveChangesAsync();

            var createdDTO = _mapper.Map<BankAccountDTO>(bankAccount);
            return CreatedAtAction(nameof(GetBankAccounts), new { id = createdDTO.Id }, createdDTO);
        }

        [Microsoft.AspNetCore.Mvc.HttpPut("bankaccounts/{id}")]
        public async Task<IActionResult> UpdateBankAccount(Guid id, [Microsoft.AspNetCore.Mvc.FromBody] BankAccountDTO updatedBankAccountDTO)
        {
            if (!ModelState.IsValid || id != updatedBankAccountDTO.Id)
                return BadRequest();

            var updatedBankAccount = _mapper.Map<BankAccount>(updatedBankAccountDTO);

            await _bankAccountService.UpdateBankAccountAsync(id, updatedBankAccount);
            await _bankAccountService.SaveChangesAsync();

            return NoContent();
        }

        [Microsoft.AspNetCore.Mvc.HttpDelete("bankaccounts/{id}")]
        public async Task<IActionResult> DeleteBankAccount(Guid id)
        {
            await _bankAccountService.DeleteBankAccountAsync(id);
            await _bankAccountService.SaveChangesAsync();

            return NoContent();
        }
    }


