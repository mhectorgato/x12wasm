﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12wasm.FieldFormatters
{
    public class MakeItLightBlue : IFieldFormatter
    {
        private readonly int[] _ordinalsToSkip;
        private readonly string _code;

        public MakeItLightBlue(string lineCode, int[] ordinalsToSkip)
        {
            _code = lineCode;
            _ordinalsToSkip = ordinalsToSkip ?? new int[0];
        }
        public void UpdateField(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (lineResult.LineCode != _code)
                return;

            if (!_ordinalsToSkip.Contains(fieldResult.Field.Ordinal))
                fieldResult.DisplayValue = $"<span style='color:lightBlue;'>{fieldResult.FileValue}</span>";
        }
    }
}
