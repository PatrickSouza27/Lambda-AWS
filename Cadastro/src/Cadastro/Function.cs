using Amazon.Lambda.Core;
using Cadastro.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Cadastro;

public class Function
{
 
    public string FunctionHandler(Usuario usuario, ILambdaContext context)
    => usuario.Cadastrar() ? "Usuario Cadastrado com sucesso!" : "Falha ao Cadastrar Usuario";
}
