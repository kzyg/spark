﻿// Copyright 2011 Intel Corporation
// All Rights Reserved
//
// Permission is granted to use, copy, distribute and prepare derivative works of this
// software for any purpose and without fee, provided, that the above copyright notice
// and this statement appear in all copies.  Intel makes no representations about the
// suitability of this software for any purpose.  THIS SOFTWARE IS PROVIDED "AS IS."
// INTEL SPECIFICALLY DISCLAIMS ALL WARRANTIES, EXPRESS OR IMPLIED, AND ALL LIABILITY,
// INCLUDING CONSEQUENTIAL AND OTHER INDIRECT DAMAGES, FOR THE USE OF THIS SOFTWARE,
// INCLUDING LIABILITY FOR INFRINGEMENT OF ANY PROPRIETARY RIGHTS, AND INCLUDING THE
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.  Intel does not
// assume any responsibility for any errors which may appear in this software nor any
// responsibility to update it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spark.Mid
{
    public class MidModuleDecl : MidContainerDecl
    {
        public MidModuleDecl(
            IBuilder parent,
            MidEmitContext context,
            MidEmitEnv env)
            : base(parent, context, env)
        {
        }

        public void AddPipeline(MidPipelineDecl pipeline)
        {
            _pipelines.Add(pipeline);
        }

        public IEnumerable<MidPipelineDecl> Pipelines { get { return _pipelines; } }

        private List<MidPipelineDecl> _pipelines = new List<MidPipelineDecl>();

        public override IMidMemberRef CreateRef(MidMemberTerm memberTerm)
        {
            throw new NotImplementedException();
        }
    }
}
