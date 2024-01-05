using Domain.Commands;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)

        {   //Toso
            //Incluir validaçãp. só podem castrar veículos com
            //até 5 anos de uso
            //To do 
            //Incluir Somente carros do tipo SUV, Sedan  e Hatch 
            command.
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
