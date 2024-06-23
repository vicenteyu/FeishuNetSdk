// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取所有节点 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 获取所有节点 响应体
/// <para>获取画板内所有的节点</para>
/// <para>接口ID：7338460461824360449</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2flist</para>
/// </summary>
public record GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto
{
    /// <summary>
    /// <para>查询结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("nodes")]
    public WhiteboardNode[]? Nodes { get; set; }

    /// <summary>
    /// <para>查询结果</para>
    /// </summary>
    public record WhiteboardNode
    {
        /// <summary>
        /// <para>节点 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：o1:1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：4</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点图形类型，目前创建节点仅支持创建图片、文本、基础图形等类型，读取到不支持创建的图形时只返回一些基础信息，如 id、type、text、style 等</para>
        /// <para>必填：是</para>
        /// <para>示例值：composite_shape</para>
        /// <para>可选值：<list type="bullet">
        /// <item>image：图片</item>
        /// <item>text_shape：文本</item>
        /// <item>group：组合</item>
        /// <item>composite_shape：基础图形</item>
        /// <item>svg：svg 图形</item>
        /// <item>connector：连线</item>
        /// <item>table：表格</item>
        /// <item>life_line：对象生命线</item>
        /// <item>activation：控制焦点</item>
        /// <item>section：分区</item>
        /// <item>table_uml：类图</item>
        /// <item>table_er：实体关系图</item>
        /// <item>sticky_note：便签</item>
        /// <item>mind_map：思维导图</item>
        /// <item>paint：画笔</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父节点 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：o1:1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：4</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>子节点</para>
        /// <para>必填：否</para>
        /// <para>最大长度：3000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("children")]
        public string[]? Children { get; set; }

        /// <summary>
        /// <para>图形相对画布的 x 轴位置信息（存在父容器时为相对父容器的坐标，父容器为组合图形 group 时，坐标是穿透的），单位为 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：132070</para>
        /// <para>最小值：-132070</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("x")]
        public float? X { get; set; }

        /// <summary>
        /// <para>图形相对画布的 y 轴位置信息（存在父容器时为相对父容器的坐标，父容器为组合图形 group 时，坐标是穿透的），单位为 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：132070</para>
        /// <para>最小值：-132070</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("y")]
        public float? Y { get; set; }

        /// <summary>
        /// <para>图形旋转角度</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：180</para>
        /// <para>最小值：-180</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("angle")]
        public float? Angle { get; set; }

        /// <summary>
        /// <para>图形宽度，单位为 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：132070</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("width")]
        public float? Width { get; set; }

        /// <summary>
        /// <para>图形高度，单位为 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：132070</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// <para>图形内文字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("text")]
        public WhiteboardNodeText? Text { get; set; }

        /// <summary>
        /// <para>图形内文字</para>
        /// </summary>
        public record WhiteboardNodeText
        {
            /// <summary>
            /// <para>文字内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：文字内容</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;

            /// <summary>
            /// <para>文字字重</para>
            /// <para>必填：否</para>
            /// <para>示例值：regular</para>
            /// <para>可选值：<list type="bullet">
            /// <item>regular：常规</item>
            /// <item>bold：加粗</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("font_weight")]
            public string? FontWeight { get; set; }

            /// <summary>
            /// <para>文字大小</para>
            /// <para>必填：否</para>
            /// <para>示例值：14</para>
            /// <para>最大值：999</para>
            /// <para>最小值：4</para>
            /// </summary>
            [JsonPropertyName("font_size")]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>水平对齐</para>
            /// <para>必填：否</para>
            /// <para>示例值：center</para>
            /// <para>可选值：<list type="bullet">
            /// <item>left：向左对齐</item>
            /// <item>center：居中对齐</item>
            /// <item>right：向右对齐</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("horizontal_align")]
            public string? HorizontalAlign { get; set; }

            /// <summary>
            /// <para>垂直对齐</para>
            /// <para>必填：否</para>
            /// <para>示例值：mid</para>
            /// <para>可选值：<list type="bullet">
            /// <item>top：顶部对齐</item>
            /// <item>mid：垂直居中</item>
            /// <item>bottom：底部对齐</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("vertical_align")]
            public string? VerticalAlign { get; set; }
        }

        /// <summary>
        /// <para>图形样式</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("style")]
        public WhiteboardNodeStyle? Style { get; set; }

        /// <summary>
        /// <para>图形样式</para>
        /// </summary>
        public record WhiteboardNodeStyle
        {
            /// <summary>
            /// <para>填充透明度</para>
            /// <para>必填：否</para>
            /// <para>示例值：50</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("fill_opacity")]
            public float? FillOpacity { get; set; }

            /// <summary>
            /// <para>边框样式</para>
            /// <para>必填：否</para>
            /// <para>示例值：solid</para>
            /// <para>可选值：<list type="bullet">
            /// <item>solid：实线</item>
            /// <item>none：无边框</item>
            /// <item>dash：虚线</item>
            /// <item>dot：点状虚线</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("border_style")]
            public string? BorderStyle { get; set; }

            /// <summary>
            /// <para>边框宽度</para>
            /// <para>必填：否</para>
            /// <para>示例值：narrow</para>
            /// <para>可选值：<list type="bullet">
            /// <item>extra_narrow：极细</item>
            /// <item>narrow：细</item>
            /// <item>medium：中</item>
            /// <item>wide：粗</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("border_width")]
            public string? BorderWidth { get; set; }

            /// <summary>
            /// <para>边框透明度</para>
            /// <para>必填：否</para>
            /// <para>示例值：50</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("border_opacity")]
            public float? BorderOpacity { get; set; }

            /// <summary>
            /// <para>水平翻折</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("h_flip")]
            public bool? HFlip { get; set; }

            /// <summary>
            /// <para>垂直翻折</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("v_flip")]
            public bool? VFlip { get; set; }
        }

        /// <summary>
        /// <para>图片</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image")]
        public WhiteboardNodeImage? Image { get; set; }

        /// <summary>
        /// <para>图片</para>
        /// </summary>
        public record WhiteboardNodeImage
        {
            /// <summary>
            /// <para>图片 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：EeSHb3qs9oSBXoxvw33bqtOsczb</para>
            /// <para>最大长度：27</para>
            /// <para>最小长度：22</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>基础图形属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("composite_shape")]
        public WhiteboardNodeCompositeShape? CompositeShape { get; set; }

        /// <summary>
        /// <para>基础图形属性</para>
        /// </summary>
        public record WhiteboardNodeCompositeShape
        {
            /// <summary>
            /// <para>基础图形的具体类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：circle</para>
            /// <para>可选值：<list type="bullet">
            /// <item>round_rect2：全圆角矩形</item>
            /// <item>ellipse：圆形</item>
            /// <item>hexagon：六边形</item>
            /// <item>cylinder：圆柱体</item>
            /// <item>parallelogram：平行四边形</item>
            /// <item>trapezoid：梯形</item>
            /// <item>triangle：三角形</item>
            /// <item>round_rect：圆角矩形</item>
            /// <item>step：步骤</item>
            /// <item>diamond：菱形</item>
            /// <item>rect：基础矩形</item>
            /// <item>star：五角星</item>
            /// <item>bubble：气泡</item>
            /// <item>pentagon：五边形</item>
            /// <item>forward_arrow：单向箭头</item>
            /// <item>document_shape：文档图形</item>
            /// <item>condition_shape：组合片段</item>
            /// <item>cloud：云朵</item>
            /// <item>cross：十字形</item>
            /// <item>step2：步骤图形2</item>
            /// <item>predefined_process：预定义流程</item>
            /// <item>delay_shape：延迟图形</item>
            /// <item>off_page_connector：跨页引用</item>
            /// <item>note_shape：注释图形</item>
            /// <item>data_process：数据处理</item>
            /// <item>data_store：数据存储</item>
            /// <item>data_store2：数据存储2</item>
            /// <item>data_store3：数据存储3</item>
            /// <item>star2：爆炸星型</item>
            /// <item>star3：四角形</item>
            /// <item>star4：六角形</item>
            /// <item>actor：角色小人</item>
            /// <item>brace：花括号</item>
            /// <item>condition_shape2：组合片段2</item>
            /// <item>double_arrow：双向箭头</item>
            /// <item>data_flow_round_rect3：数据处理（正方圆角矩形）</item>
            /// <item>rect_bubble：矩形气泡</item>
            /// <item>manual_input：手动输入图形</item>
            /// <item>flow_chart_round_rect：流程图圆角矩形</item>
            /// <item>flow_chart_round_rect2：流程图全圆角矩形</item>
            /// <item>flow_chart_diamond：流程图判定</item>
            /// <item>flow_chart_parallelogram：流程图数据</item>
            /// <item>flow_chart_cylinder：流程图数据库</item>
            /// <item>flow_chart_trapezoid：流程图手动操作</item>
            /// <item>flow_chart_hexagon：流程图准备</item>
            /// <item>data_flow_round_rect：数据流外部实体</item>
            /// <item>data_flow_ellipse：数据流数据处理</item>
            /// <item>backward_arrow：反向箭头（左箭头）</item>
            /// <item>brace_reverse：反向花括号（左括号）</item>
            /// <item>flow_chart_mq：消息队列</item>
            /// <item>horiz_cylinder：水平方向圆柱体</item>
            /// <item>class_interface：类图，接口</item>
            /// <item>classifier：类图，类目</item>
            /// <item>circular_ring：圆环</item>
            /// <item>pie：扇形</item>
            /// <item>right_triangle：直角三角形</item>
            /// <item>octagon：八边形</item>
            /// <item>state_start：状态图，开始</item>
            /// <item>state_end：状态图，结束</item>
            /// <item>state_concurrence：状态图，并发</item>
            /// <item>component_shape：组件</item>
            /// <item>component_shape2：组件2</item>
            /// <item>component_interface：组件，接口</item>
            /// <item>component_required_interface：组件，需求接口</item>
            /// <item>component_assembly：组件，组装</item>
            /// <item>cube：立方体</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>连线属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("connector")]
        public WhiteboardNodeConnector? Connector { get; set; }

        /// <summary>
        /// <para>连线属性</para>
        /// </summary>
        public record WhiteboardNodeConnector
        {
            /// <summary>
            /// <para>连线连接的起点图形</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("start_object")]
            public ConnectorAttachedObject? StartObject { get; set; }

            /// <summary>
            /// <para>连线连接的起点图形</para>
            /// </summary>
            public record ConnectorAttachedObject
            {
                /// <summary>
                /// <para>连接图形的 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：o1:1</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：4</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }
            }

            /// <summary>
            /// <para>连线连接的终点图形</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("end_object")]
            public ConnectorAttachedObject? EndObject { get; set; }

            /// <summary>
            /// <para>连线文本</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("captions")]
            public ConnectorCaption? Captions { get; set; }

            /// <summary>
            /// <para>连线文本</para>
            /// </summary>
            public record ConnectorCaption
            {
                /// <summary>
                /// <para>文本</para>
                /// <para>必填：否</para>
                /// <para>最大长度：1024</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("data")]
                public Text[]? Datas { get; set; }

                /// <summary>
                /// <para>文本</para>
                /// </summary>
                public record Text
                {
                    /// <summary>
                    /// <para>文字内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文字内容</para>
                    /// <para>最大长度：1024</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("text")]
                    public string TextSuffix { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文字字重</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：regular</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>regular：常规</item>
                    /// <item>bold：加粗</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("font_weight")]
                    public string? FontWeight { get; set; }

                    /// <summary>
                    /// <para>文字大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：14</para>
                    /// <para>最大值：999</para>
                    /// <para>最小值：4</para>
                    /// </summary>
                    [JsonPropertyName("font_size")]
                    public int? FontSize { get; set; }

                    /// <summary>
                    /// <para>水平对齐</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：center</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>left：向左对齐</item>
                    /// <item>center：居中对齐</item>
                    /// <item>right：向右对齐</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("horizontal_align")]
                    public string? HorizontalAlign { get; set; }

                    /// <summary>
                    /// <para>垂直对齐</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：mid</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>top：顶部对齐</item>
                    /// <item>mid：垂直居中</item>
                    /// <item>bottom：底部对齐</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("vertical_align")]
                    public string? VerticalAlign { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>分区属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("section")]
        public WhiteboardNodeSection? Section { get; set; }

        /// <summary>
        /// <para>分区属性</para>
        /// </summary>
        public record WhiteboardNodeSection
        {
            /// <summary>
            /// <para>分区标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：分区</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }
        }

        /// <summary>
        /// <para>表格属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("table")]
        public WhiteboardNodeTable? Table { get; set; }

        /// <summary>
        /// <para>表格属性</para>
        /// </summary>
        public record WhiteboardNodeTable
        {
            /// <summary>
            /// <para>元信息</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("meta")]
            public TableMeta Meta { get; set; } = new();

            /// <summary>
            /// <para>元信息</para>
            /// </summary>
            public record TableMeta
            {
                /// <summary>
                /// <para>行数</para>
                /// <para>必填：是</para>
                /// <para>示例值：3</para>
                /// <para>最大值：10000</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("row_num")]
                public int RowNum { get; set; }

                /// <summary>
                /// <para>列数</para>
                /// <para>必填：是</para>
                /// <para>示例值：3</para>
                /// <para>最大值：10000</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("col_num")]
                public int ColNum { get; set; }
            }

            /// <summary>
            /// <para>标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：表格</para>
            /// <para>最大长度：1024</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>单元格列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("cells")]
            public TableCell[]? Cells { get; set; }

            /// <summary>
            /// <para>单元格列表</para>
            /// </summary>
            public record TableCell
            {
                /// <summary>
                /// <para>行下标，从 1 开始</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最大值：10000</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("row_index")]
                public int RowIndex { get; set; }

                /// <summary>
                /// <para>列下标，从 1 开始</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最大值：10000</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("col_index")]
                public int ColIndex { get; set; }

                /// <summary>
                /// <para>单元格合并信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("merge_info")]
                public TableCellMergeInfo? MergeInfo { get; set; }

                /// <summary>
                /// <para>单元格合并信息</para>
                /// </summary>
                public record TableCellMergeInfo
                {
                    /// <summary>
                    /// <para>从当前行索引起被合并的连续行数</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：2</para>
                    /// <para>最大值：10000</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("row_span")]
                    public int RowSpan { get; set; }

                    /// <summary>
                    /// <para>从当前列索引起被合并的连续列数</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：2</para>
                    /// <para>最大值：10000</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("col_span")]
                    public int ColSpan { get; set; }
                }

                /// <summary>
                /// <para>单元格包含的子节点 id</para>
                /// <para>必填：否</para>
                /// <para>最大长度：3000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("children")]
                public string[]? Children { get; set; }

                /// <summary>
                /// <para>单元格内文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text")]
                public TableCellText? Text { get; set; }

                /// <summary>
                /// <para>单元格内文字</para>
                /// </summary>
                public record TableCellText
                {
                    /// <summary>
                    /// <para>文字内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文字内容</para>
                    /// <para>最大长度：1024</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("text")]
                    public string Text { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文字字重</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：regular</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>regular：常规</item>
                    /// <item>bold：加粗</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("font_weight")]
                    public string? FontWeight { get; set; }

                    /// <summary>
                    /// <para>文字大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：14</para>
                    /// <para>最大值：999</para>
                    /// <para>最小值：4</para>
                    /// </summary>
                    [JsonPropertyName("font_size")]
                    public int? FontSize { get; set; }

                    /// <summary>
                    /// <para>水平对齐</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：center</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>left：向左对齐</item>
                    /// <item>center：居中对齐</item>
                    /// <item>right：向右对齐</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("horizontal_align")]
                    public string? HorizontalAlign { get; set; }

                    /// <summary>
                    /// <para>垂直对齐</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：mid</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>top：顶部对齐</item>
                    /// <item>mid：垂直居中</item>
                    /// <item>bottom：底部对齐</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("vertical_align")]
                    public string? VerticalAlign { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>思维导图属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mind_map")]
        public WhiteboardNodeMindMap? MindMap { get; set; }

        /// <summary>
        /// <para>思维导图属性</para>
        /// </summary>
        public record WhiteboardNodeMindMap
        {
            /// <summary>
            /// <para>思维导图父节点 id ，为空表示是思维导图的根节点</para>
            /// <para>必填：否</para>
            /// <para>示例值：z1:1</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：4</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }
        }
    }
}
