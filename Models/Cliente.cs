namespace RCPet.Models;

public class Cliente
{
    // create atributes for class
    public int Id {get; set;}
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Email {get; set;}
    public string Paciente {get; set;}
    

    // create builder client model

    public Cliente(int id, string nome, string cpf, string email, string paciente )
    {
        this.Id = id;
        this.Nome = nome;
        this. Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

}