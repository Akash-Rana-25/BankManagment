using AutoMapper;
using BankManagment_Domain.Entity;
using BankManagment_DTO;
using Microsoft.AspNetCore.Mvc;
using BankManagment_Services;
using System.Diagnostics;
using System.Web.Http;

[RoutePrefix("api/accounttypes")]
public class AccountTypeController : Controller
{
    private readonly IAccountTypeService _accountTypeService;
    private readonly IMapper _mapper;

    public AccountTypeController(IAccountTypeService accountTypeService, IMapper mapper)
    {
        _accountTypeService = accountTypeService;
        _mapper = mapper;
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("accounttypes")]
    public async Task<IActionResult> GetAccountTypes()
    {
        var accountTypes = await _accountTypeService.GetAllAccountTypesAsync();
        var accountTypeDTOs = _mapper.Map<List<AccountTypeDTO>>(accountTypes);
        return Ok(accountTypeDTOs);
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("accounttypes")]
    public async Task<IActionResult> CreateAccountType([Microsoft.AspNetCore.Mvc.FromBody] AccountTypeDTO accountTypeDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var accountType = _mapper.Map<AccountType>(accountTypeDTO);

        await _accountTypeService.CreateAccountTypeAsync(accountType);
        await _accountTypeService.SaveChangesAsync();

        var createdDTO = _mapper.Map<AccountTypeDTO>(accountType);
        return CreatedAtAction(nameof(GetAccountTypes), new { id = createdDTO.Id }, createdDTO);
    }

    [Microsoft.AspNetCore.Mvc.HttpPut("accounttypes/{id}")]
    public async Task<IActionResult> UpdateAccountType(Guid id, [Microsoft.AspNetCore.Mvc.FromBody] AccountTypeDTO updatedAccountTypeDTO)
    {
        Debug.WriteLine("UpdateAccountType called with id in Contoller: " + id);
        Debug.WriteLine("Updated AccountTypeDTO: " + updatedAccountTypeDTO);

        if (!ModelState.IsValid)
        {
            Debug.WriteLine("ModelState is not valid. Returning BadRequest.");
            return BadRequest();
        }

        if (id != updatedAccountTypeDTO.Id)
        {
            Debug.WriteLine("id does not match. Returning BadRequest.");
            return BadRequest();
        }

        var updatedAccountType = _mapper.Map<AccountType>(updatedAccountTypeDTO);

        Debug.WriteLine("Mapped AccountType: " + updatedAccountType);

        await _accountTypeService.UpdateAccountTypeAsync(id, updatedAccountType);
        await _accountTypeService.SaveChangesAsync();

        Debug.WriteLine("UpdateAccountTypeAsync and SaveChangesAsync completed.");

        return NoContent();
    }


    [Microsoft.AspNetCore.Mvc.HttpDelete("accounttypes/{id}")]
    public async Task<IActionResult> DeleteAccountType(Guid id)
    {
        await _accountTypeService.DeleteAccountTypeAsync(id);
        await _accountTypeService.SaveChangesAsync();

        return NoContent();
    }
}
