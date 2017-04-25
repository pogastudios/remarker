// ***********************************************************************
// Assembly         : Remarker
// Solution         : CommentPlus
// File name        : MicroCommentFormat.cs
// Author           : Gil Yoder
// Created          : 08 29,  2014
//
// Last Modified By : Gil Yoder
// Last Modified On : 08 29, 2014
// ***********************************************************************

namespace YoderZone.Extensions.Remarker.FormatDefinitions
{
#region Imports

    using System.ComponentModel.Composition;

    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Utilities;

    using YoderZone.Extensions.Remarker.Utilities;

    #endregion

/// <summary>
///     A micro comment format.
/// </summary>
/// <seealso
///     cref="T:Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition" />
[Name(Definitions.CommentNormalMicroType)]
[UserVisible(true)]
[Order(After = Priority.High)]
[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames =
                        Definitions.CommentNormalMicroType)]
public class MicroCommentFormat : ClassificationFormatDefinition
{
    #region Constructors and Destructors

    /// <summary>
    ///     Initializes a new instance of the YoderZone.Extensions.MicroCommentFormat
    ///     class.
    /// </summary>
    public MicroCommentFormat()
    {
        this.DisplayName = "Remarker Comment - Micro (---)";
        this.IsBold = false;
        this.ForegroundColor = Resources.NormalCommentColor;
        this.ForegroundCustomizable = true;
        this.BackgroundCustomizable = false;
    }

    #endregion
}
}