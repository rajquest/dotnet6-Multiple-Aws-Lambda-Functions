using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MultipleAwsLambdaFunctions;

public class Function
{ 
    public string ToUpper(ILambdaContext context)
    {
        string input = "Test String";
        return input.ToUpper();
    }
    public string ToLower(ILambdaContext context)
    {
        string input = "Test String";
        return input.ToLower();
    }
}