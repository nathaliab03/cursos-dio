using POO___Desafio.Models;

Console.WriteLine("Cadastro Iniciado!");

Console.WriteLine("Escolha a opção de modelo para cadastro");
Console.WriteLine("1- Nokia");
Console.WriteLine("2- iPhone");

int option = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número do telefone");
string number = Console.ReadLine();

Console.WriteLine("Digite o modelo do aparelho");
string model = Console.ReadLine();

Console.WriteLine("Digite o imei do aparelho");
string imei = Console.ReadLine();

Console.WriteLine("Digite a quantidade de memória do aparelho");
int memory = int.Parse(Console.ReadLine());

if(number == "" || model == "" || imei == "" || memory <= 0)
{
    Console.WriteLine("Todos os campos devem ser preenchidos");
}
else
{
    switch(option){
        case 1:
        Smartphone nokia = new Nokia(number: number, model: model, imei: imei, memory: memory);
        nokia.Call();
        nokia.AppInstall("Whatsapp");
        break;

        case 2:
        Smartphone iphone = new Iphone(number: number, model: model, imei: imei, memory: memory);
        iphone.Call();
        iphone.AppInstall("Whatsapp");
        break;
    }
    

}

