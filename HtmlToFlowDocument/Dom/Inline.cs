﻿// Copyright (c) Dr. Dirk Lellinger. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlToFlowDocument.Dom
{
  public abstract class Inline : TextElement
  {
    public ExCSS.VerticalAlignment? VerticalAlignment { get; set; }
  }
}
