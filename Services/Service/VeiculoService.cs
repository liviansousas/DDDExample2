using Domain.Commands;
using Domain.ENums;
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

        public async Task<string> PostAsync(VeiculoCommand command)
            
        {  if (command == null)
                return "Todos os Campos são Obrigatórios";
                
            //To do
            //Incluir validação, só podem cadastrar veículos com
            //até 5 anos de uso
            //To do 
            //Incluir Somente carros do tipo SUV, Sedan  e Hatch 


            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)

                return "O Ano do veículo é menor que o permitido";

            if (command.TipoVeiculo != ETipoVeiculo.suv
                && command.TipoVeiculo != ETipoVeiculo.picape
                && command.TipoVeiculo != ETipoVeiculo.sedan
                )
                return "O tipo de Veículo não é permitido";

            return _veiculoRepository.PostAsync(command);


            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
