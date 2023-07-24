using Amazon.Lambda.Core;
using Cadastro.Controller;
using Cadastro.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Todos;

public class Function
{

    public List<Usuario> FunctionHandler()
        => new TodosController().Todos();

}
