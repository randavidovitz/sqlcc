﻿using System.Collections.Generic;
using SQLCC.Core.Objects;

namespace SQLCC.Core.Interfaces
{
   internal interface IDbTraceCodeFormatter : IExtension
   {
      string StartHighlightMarkUp { get;  }
      string EndHighlightMarkUp { get; }
      string FormatCodeWithHighlights(string code, List<DbCodeSegment> codeSegments);
   }
}
