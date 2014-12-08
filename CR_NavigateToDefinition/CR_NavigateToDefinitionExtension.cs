using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_NavigateToDefinition
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_NavigateToDefinitionExtension : IVsixPluginExtension { }
}