﻿namespace nuComponents.DataTypes.PropertyEditors.XmlCheckBoxPicker
{
    using Umbraco.Core.PropertyEditors;

    internal class XmlCheckBoxPickerPreValueEditor : PreValueEditor
    {
        [PreValueField("dataSource", "", EmbeddedResource.RootUrl + "XmlDataSource/XmlDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [PreValueField("customLabel", "Label Macro", EmbeddedResource.RootUrl + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [PreValueField("layoutDirection", "Layout Direction", EmbeddedResource.RootUrl + "LayoutDirection/LayoutDirectionConfig.html")]
        public string LayoutDirection { get; set; }

        [PreValueField("relationTypeMapping", "", EmbeddedResource.RootUrl + "RelationTypeMapping/RelationTypeMappingConfig.html", HideLabel = true)]
        public string RelationTypeMapping { get; set; }

        [PreValueField("saveFormat", "Save Format", EmbeddedResource.RootUrl + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}
