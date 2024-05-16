namespace Desafio.Services
{
    using Desafio.Models;
    using System;
    using System.Collections.Generic;

    public interface IRegistroService
    {
        string Register(int idEmployee, DateTime date, string registerType, string businessLocation);

    }
}
