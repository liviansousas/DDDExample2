using Domain.Entidades;
using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Numerics;
using Microsoft.Data.SqlClient;
using Dapper;

namespace Infraestructure.Repository
{
    internal class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = " ";

        public void PostAsync()
        {
        }
        public void GetAsync()
        {
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {

            string queryInsert = @"
            INSERT INTO Veiculo(Placa, AnoFabricacao, TipoVeiculoId, Estado, MontadoraId)
            VALUES(@Placa, @AnoFabricacao, @TipoVeiculoId, @Estado, @MontadoraId
            throw new NotImplementedException()";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = command.Montadora

                });

                return "Veiculo Cadastrado com sucesso";
            }
        }
    }



}
