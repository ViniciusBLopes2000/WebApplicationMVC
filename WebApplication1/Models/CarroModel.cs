using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarroModel
    {
        public string Modelo { get; set; }
        public string Dono { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }

        public CarroModel()
        {
            Modelo = "Mitsubish - Lancer";
            Dono = "Emerson da Silva Rosa";
            Placa = "DEF-5678";
            Ano = 2020;
        }

        public static CarroModel CriarCarro()
        {
            var carro = new CarroModel();
            carro.Modelo = "Porsche - Huracan";
            return carro;
        }
        public static List<CarroModel> CriarLista()
        {
            var lista = new List<CarroModel>();

            lista.Add(new CarroModel() { Modelo = "Toyota - Corolla", Dono = "Vinícius Bezerra Lopes", Placa = "XYZ-9876", Ano = 2010 });
            lista.Add(new CarroModel() { Modelo = "Fiat - Cronos ", Dono = "Alex Machado Ferreira Sampaio", Placa = "MNO-5432", Ano = 2021 });
            lista.Add(new CarroModel() { Modelo = "Jeep - Compass ", Dono = " Maria Eduarda de Azevedo ", Placa = "QRS-1234", Ano = 2022 });
            lista.Add(new CarroModel() { Modelo = "Fiat - Toro", Dono = "Marco Aurélio de Barros ", Placa = "LMN-7890", Ano = 2020 });
            lista.Add(new CarroModel() { Modelo = "Honda - Civic ", Dono = "Bianca Grazielly de Lima", Placa = "GHI-4567", Ano = 2017 });
            lista.Add(new CarroModel() { Modelo = "Ford - Ka ", Dono = "Erik Paschoine de Oliveira ", Placa = "UVW-2109", Ano = 2011 });

            return lista;
        }
    }
}
