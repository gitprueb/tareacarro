


using tarea_carro.clases;

carro erCarro = new carro("bmw", 2022, "azul");

Console.WriteLine($"EL carro de Ericson es {erCarro.Marca}");
Console.WriteLine($"el carro de Ericson es modelo{erCarro.Modelo}");



erCarro.EncenderMotor();
Console.WriteLine(erCarro.Bocina());



for (int i = 0; i < 21; i++)
{
    erCarro.Acelerar();
    

}
for (int i = 0; i < 10; i++)
{
    erCarro.Desacelerar();
    
}
for (int i = 0; i < 4; i++)
{
    erCarro.FRENAR();
    
}


Console.WriteLine(erCarro.Bocina());
erCarro.ApagarMotor();