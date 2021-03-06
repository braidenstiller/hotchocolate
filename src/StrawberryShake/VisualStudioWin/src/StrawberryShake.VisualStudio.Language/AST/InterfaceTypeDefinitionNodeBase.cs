﻿using System.Collections.Generic;

namespace StrawberryShake.VisualStudio.Language
{
    public abstract class InterfaceTypeDefinitionNodeBase
        : ComplexTypeDefinitionNodeBase
    {
        protected InterfaceTypeDefinitionNodeBase(
            Location location,
            NameNode name,
            IReadOnlyList<DirectiveNode> directives,
            IReadOnlyList<FieldDefinitionNode> fields)
            : base(location, name, directives, fields)
        {
        }
    }
}
