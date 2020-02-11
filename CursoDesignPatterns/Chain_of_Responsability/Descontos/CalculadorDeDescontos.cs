using CursoDesignPatterns.Entidades;

namespace Chain_of_Responsability.Descontos
{
    public class CalculadorDeDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            var desconto5itens = new DescontoPorCincoItens();
            var desconto500reais = new DescontoPorMaisQuinhentosReais();
            var semDesconto = new SemDesconto();

            desconto5itens.Proximo = desconto500reais;
            desconto500reais.Proximo = semDesconto;

            return desconto5itens.Desconto(orcamento);
        }
    }
}