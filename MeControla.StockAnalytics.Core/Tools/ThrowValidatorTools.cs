using FluentValidation;
using MeControla.Core.Data.Dtos;
using MeControla.Core.Data.Entities;
using MeControla.StockAnalytics.Core.Exceptions;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MeControla.StockAnalytics.Core.Tools
{
    [StackTraceHidden]
    internal static class ThrowValidatorTools
    {
        [DoesNotReturn]
        internal static void ThrowValidator<TEntity, TInputDto>(IValidator<TInputDto> validator, TInputDto input)
            where TEntity : class, IModificationDateTimeEntity
            where TInputDto : class, IInputDto
        {
            ArgumentNullException.ThrowIfNull(validator);

            var result = validator.Validate(input);
            if (result.IsValid)
                return;

            throw new FormValidationException(typeof(TEntity), result);
        }
    }
}