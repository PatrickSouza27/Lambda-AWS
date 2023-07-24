using Amazon.Lambda.Core;
using Cadastro.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Atualizar;

public class Function
{
    public string FunctionHandler(AtualizarView input, ILambdaContext context)
        => input.Atualizar() ? "Atualizado com Sucesso" : "Erro ao Atualizar";

}
