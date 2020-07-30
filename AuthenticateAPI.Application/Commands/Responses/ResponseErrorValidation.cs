using AuthenticateAPI.Application.Commands.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthenticateAPI.Application.Commands.Responses
{
    public class ResponseErrorValidation : BaseResponse
    {
        public List<Dictionary<string, string>> Erros { get; set; }

        public ResponseErrorValidation(List<ValidationFailure> validation)
        {
            var result = validation
                            .ToDictionary(
                                e => e.PropertyName,
                                e => e.ErrorMessage);

            Erros.Add(result);
        }
    }


}
