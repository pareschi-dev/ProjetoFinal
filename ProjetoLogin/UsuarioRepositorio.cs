using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace ProjetoLogin
{
    public static class UsuarioRepositorio
    {
        private static readonly string arquivoUsuarios = "usuarios.json";

        public static List<Usuario> CarregarUsuarios()
        {
            if (File.Exists(arquivoUsuarios))
            {
                string json = File.ReadAllText(arquivoUsuarios);
                return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
            }
            return new List<Usuario>();
        }

        public static void SalvarUsuarios(List<Usuario> usuarios)
        {
            string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(arquivoUsuarios, json);
        }

        public static void AdicionarUsuario(Usuario novoUsuario)
        {
            var usuarios = CarregarUsuarios();
            novoUsuario.Senha = CriptografarSenha(novoUsuario.Senha);
            usuarios.Add(novoUsuario);
            SalvarUsuarios(usuarios);
        }

        public static Usuario? BuscarPorEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            var usuarios = CarregarUsuarios();
            return usuarios.FirstOrDefault(u => u.Email == email);
        }

        private static string CriptografarSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
                throw new ArgumentException("Senha não pode ser vazia", nameof(senha));

            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            return Convert.ToBase64String(bytes);
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            if (string.IsNullOrEmpty(senhaDigitada) || string.IsNullOrEmpty(senhaArmazenada))
                return false;

            return CriptografarSenha(senhaDigitada) == senhaArmazenada;
        }
    }
}