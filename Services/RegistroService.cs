using Desafio.Data;
using Desafio.Models;
using Desafio.Services;
using Microsoft.Win32;
using System;

public class RegistroService : IRegistroService
{
    private readonly ApplicationDbContext _dbContext;

    public RegistroService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public string Register(int idEmployee, DateTime date, string registerType, string businessLocation)
    {
        try
        {

            Registro nuevoRegistro = new Registro
            {
                IdEmployee = idEmployee,
                Date = date,
                RegisterType = registerType,
                BusinessLocation = businessLocation
            };

            _dbContext.Registros.Add(nuevoRegistro);
            _dbContext.SaveChanges();

            return "Correcto";
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }
}
