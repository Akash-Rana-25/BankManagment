using AutoMapper;
using BankManagment_Domain.Entity;
using BankManagment_DTO;
using Microsoft.AspNetCore.Mvc;
using BankManagment_Services;
using System.Web.Http;

[RoutePrefix("api/banktransactions")]
public class BankTransactionsController : Controller
{
    private readonly IBankTransactionService _bankTransactionService;
    private readonly IMapper _mapper;

    public BankTransactionsController(IBankTransactionService bankTransactionService, IMapper mapper)
    {
        _bankTransactionService = bankTransactionService;
        _mapper = mapper;
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("banktransactions")]
    public async Task<IActionResult> GetBankTransactions()
    {
        var bankTransactions = await _bankTransactionService.GetAllBankTransactionsAsync();
        var bankTransactionDTOs = _mapper.Map<List<BankTransactionDTO>>(bankTransactions);
        return Ok(bankTransactionDTOs);
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("banktransactions")]
    public async Task<IActionResult> CreateBankTransaction([Microsoft.AspNetCore.Mvc.FromBody] BankTransactionDTO bankTransactionDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var bankTransaction = _mapper.Map<BankTransaction>(bankTransactionDTO);

        await _bankTransactionService.CreateBankTransactionAsync(bankTransaction);
        await _bankTransactionService.SaveChangesAsync();

        var createdDTO = _mapper.Map<BankTransactionDTO>(bankTransaction);
        return CreatedAtAction(nameof(GetBankTransactions), new { id = createdDTO.Id }, createdDTO);
    }

    [Microsoft.AspNetCore.Mvc.HttpPut("banktransactions/{id}")]
    public async Task<IActionResult> UpdateBankTransaction(Guid id, [Microsoft.AspNetCore.Mvc.FromBody] BankTransactionDTO updatedBankTransactionDTO)
    {
        if (!ModelState.IsValid || id != updatedBankTransactionDTO.Id)
            return BadRequest();

        var updatedBankTransaction = _mapper.Map<BankTransaction>(updatedBankTransactionDTO);

        await _bankTransactionService.UpdateBankTransactionAsync(id, updatedBankTransaction);
        await _bankTransactionService.SaveChangesAsync();

        return NoContent();
    }

    [Microsoft.AspNetCore.Mvc.HttpDelete("banktransactions/{id}")]
    public async Task<IActionResult> DeleteBankTransaction(Guid id)
    {
        await _bankTransactionService.DeleteBankTransactionAsync(id);
        await _bankTransactionService.SaveChangesAsync();

        return NoContent();
    }
}
