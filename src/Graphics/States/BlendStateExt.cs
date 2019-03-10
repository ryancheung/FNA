using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
    public partial class BlendState
    {
		public static readonly BlendState Default = new BlendState(
			"BlendState.Default",
			Blend.One,
			Blend.One,
			Blend.InverseSourceAlpha,
			Blend.InverseSourceAlpha
		);
    }
}
