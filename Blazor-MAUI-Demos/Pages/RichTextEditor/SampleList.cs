#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_MAUI_Demos;
namespace Blazor_MAUI_Demos
{
    internal partial class SampleConfig
    {
        public List<Sample> RichTextEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/overview",
                FileName = "Overview.razor",
                NotificationDescription = new string[] { @"The Rich Text Editor overview sample has been updated to include the InlineCode feature. This enhancement allows users to format code snippets inline within the editor." },
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "IFrame Mode",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/iframe-functionalities",
                FileName = "Iframe-Functionalities.razor",
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Image Option",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/image",
                FileName = "Image.razor"
            },
             new Sample
            {
                Name = "Insert Media",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url ="rich-text-editor/insert-media",
                FileName = "Insert-Media.razor",
            },
            new Sample
            {
                Name = "Resizeable Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/resize-editor",
                FileName = "Resize-Editor.razor"
            },
            new Sample
            {
                Name = "Autosave Editor",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/auto-save",
                FileName = "AutoSave.razor"
            },
            new Sample
            {
                Name = "Form Validation",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/form-validation",
                FileName = "Form-Validation.razor"
            },
            new Sample
            {
                Name = "Toolbar Type",
                Category = "Rich Text Editor",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/types",
                FileName = "Types.razor"
            },
            new Sample
            {
                Name = "@ Mention",
                Category = "Mention Integration",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/mention-integration",
                FileName = "Mention-Integration.razor"
            },
            new Sample
            {
                Name = "Overview",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-overview",
                FileName = "Markdown-Overview.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "Markdown",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/markdown-custom-format",
                FileName = "Markdown-Custom-Format.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/api",
                FileName = "Api.razor"
            },
             new Sample
            {
                Name = "Events",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/events",
                FileName = "Events.razor"
            },
            new Sample
            {
                Name = "Forum Post Editor",
                Category = "Miscellaneous",
                Directory = "RichTextEditor/RichTextEditor",
                Url = "rich-text-editor/usecase",
                FileName = "UseCase.razor"
            }
        };        
    }

}
