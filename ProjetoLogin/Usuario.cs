using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

public class Usuario
{
    public string Email { get; set; }
    public string Senha { get; set; }

    public Usuario(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
}