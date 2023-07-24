using Amazon.Lambda.Core;
using Cadastro.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Remover;

public class Function
{
    public string FunctionHandler(int Id, ILambdaContext context)
     => new DeleteIdModel(Id).Remover() ? "Excluido com sucesso" : "Erro ao Excluir";
}
