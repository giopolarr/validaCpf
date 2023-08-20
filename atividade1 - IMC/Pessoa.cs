public class Pessoa
{
    private string nome;
    private string cpf;
    private double altura;
    private double peso;
    private string sexo;
    private string idade;

    public Pessoa(string nome, string cpf, double altura, double peso, string sexo, string idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.altura = altura;
        this.peso = peso;
        this.sexo = sexo;
        this.idade = idade;

    }
    public (double, string, string) CalcularIMC()
    {
        double imc = this.peso / (altura * altura);

        if(imc < 18.5)
        {
            return (imc, "Magreza", "0");
        }
        else if( imc >=  18.5 && imc <= 24.9)
        {
            return (imc,"normal", "0");
        }
        else if( imc >= 25 && imc <= 29.9) 
        { 
            return (imc, "sobrepeso", "I");
        }
        else if(imc >= 30 && imc <= 39.9) 
        {
            return (imc, "obesidade", "II");
        }
        else if (imc >= 40) 
        {
            return (imc, "obesidade grave", "III");
        }
        else 
        {
            return (imc, "inválido", "");
                
        }
    }
    
}