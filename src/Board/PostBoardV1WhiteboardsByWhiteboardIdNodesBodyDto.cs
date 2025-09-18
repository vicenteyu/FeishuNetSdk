// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="PostBoardV1WhiteboardsByWhiteboardIdNodesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建节点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 创建节点 请求体
/// <para>创建画板节点，支持批量创建、创建含父子关系的节点等。</para>
/// <para>接口ID：7545367804831629314</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate</para>
/// </summary>
public record PostBoardV1WhiteboardsByWhiteboardIdNodesBodyDto
{
    /// <summary>
    /// <para>子节点数据，不允许传入空数组</para>
    /// <para>必填：否</para>
    /// <para>最大长度：3000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("nodes")]
    public WhiteboardNode[]? Nodes { get; set; }

    /// <summary>
    /// <para>子节点数据，不允许传入空数组</para>
    /// </summary>
    public record WhiteboardNode
    {
        /// <summary>
        /// <para>节点 id，用于唯一标识此节点，不能重复，在创建父子节点、关联其它节点做标记使用</para>
        /// <para>必填：是</para>
        /// <para>示例值：o1:1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点图形类型</para>
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
        /// <item>combined_fragment：组合片段</item>
        /// <item>mind_map_root：思维导图根节点属性</item>
        /// <item>mind_map_node：思维导图节点属性</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父节点 id，必须是已存在的节点或者在本次创建的节点列表内</para>
        /// <para>必填：否</para>
        /// <para>示例值：n1:1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

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
        /// <para>图形旋转角度，单位度</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// <para>最大值：180</para>
        /// <para>最小值：-180</para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("angle")]
        public float? Angle { get; set; }

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
        public TextSuffix? Text { get; set; }

        /// <summary>
        /// <para>图形样式</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("style")]
        public StyleSuffix? Style { get; set; }

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
            /// <para>图片 token，通过云文档下的素材上传接口 [上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all) 上传图片后返回的 token</para>
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
            /// <item>boundary：边界</item>
            /// <item>control：控制</item>
            /// <item>entity：实体</item>
            /// <item>data_base：数据库</item>
            /// <item>boundary：边界</item>
            /// <item>queue：队列</item>
            /// <item>collection：集合</item>
            /// <item>actor_lifeline：角色生命线</item>
            /// <item>object_lifeline：对象生命线</item>
            /// <item>mind_node_full_round_rect：思维导图全圆角矩形</item>
            /// <item>mind_node_round_rect：思维导图圆角矩形</item>
            /// <item>mind_node_text：思维导图文本图形</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>饼图属性，type=pie时需要设置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("pie")]
            public WhiteboardNodeCompositeShapePie? Pie { get; set; }

            /// <summary>
            /// <para>饼图属性，type=pie时需要设置</para>
            /// </summary>
            public record WhiteboardNodeCompositeShapePie
            {
                /// <summary>
                /// <para>开始径向边角度，水平向右x轴正方向为0度，顺时针方向角度值递增，单位度</para>
                /// <para>必填：是</para>
                /// <para>示例值：30.0</para>
                /// <para>最大值：360.0</para>
                /// <para>最小值：0.0</para>
                /// </summary>
                [JsonPropertyName("start_radial_line_angle")]
                public float StartRadialLineAngle { get; set; }

                /// <summary>
                /// <para>圆心角角度，角度方向为始径向边逆时针方向，单位度</para>
                /// <para>必填：是</para>
                /// <para>示例值：40.0</para>
                /// <para>最大值：360.0</para>
                /// <para>最小值：0.0</para>
                /// </summary>
                [JsonPropertyName("central_angle")]
                public float CentralAngle { get; set; }

                /// <summary>
                /// <para>半径长度，单位 px</para>
                /// <para>必填：是</para>
                /// <para>示例值：10</para>
                /// <para>最大值：10000000000</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonPropertyName("radius")]
                public float Radius { get; set; }

                /// <summary>
                /// <para>扇区占比，0为一个圆周线，1为一个圆盘</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：1</para>
                /// <para>最小值：0</para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("sector_ratio")]
                public float? SectorRatio { get; set; }
            }
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
            /// <para>连线端点信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("start")]
            public ConnectorInfo? Start { get; set; }

            /// <summary>
            /// <para>连线端点信息</para>
            /// </summary>
            public record ConnectorInfo
            {
                /// <summary>
                /// <para>连接图形信息，与position参数二选一，同时设置时attached_object生效</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("attached_object")]
                public ConnectorAttachedObject? AttachedObject { get; set; }

                /// <summary>
                /// <para>连线端点在画布内的坐标，position与attached_object二选一，position与attached_object 同时设置时 attched_object 生效</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("position")]
                public Point? Position { get; set; }

                /// <summary>
                /// <para>连线端点箭头样式</para>
                /// <para>必填：否</para>
                /// <para>示例值：line_arrow</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>none：无箭头样式</item>
                /// <item>line_arrow：线型箭头</item>
                /// <item>triangle_arrow：三角形箭头</item>
                /// <item>empty_triangle_arrow：空心三角形箭头</item>
                /// <item>circle_arrow：圆形箭头</item>
                /// <item>empty_circle_arrow：空心圆形箭头</item>
                /// <item>diamond_arrow：菱形箭头</item>
                /// <item>empty_diamond_arrow：空心菱形箭头</item>
                /// <item>single_arrow：单箭头</item>
                /// <item>multi_arrow：多箭头</item>
                /// <item>exact_single_arrow：精确单箭头</item>
                /// <item>zero_or_multi_arrow：零个或多个箭头</item>
                /// <item>zero_or_single_arrow：零个或单个箭头</item>
                /// <item>single_or_multi_arrow：单个或多个箭头</item>
                /// <item>x_arrow：x型箭头</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("arrow_style")]
                public string? ArrowStyle { get; set; }
            }

            /// <summary>
            /// <para>连线端点信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("end")]
            public ConnectorInfo? End { get; set; }

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
                public TextSuffix[]? Datas { get; set; }
            }

            /// <summary>
            /// <para>连线类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：straight</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>straight：直线</item>
            /// <item>polyline：折线</item>
            /// <item>curve：曲线</item>
            /// <item>right_angled_polyline：直角折线</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("shape")]
            public string? Shape { get; set; }

            /// <summary>
            /// <para>连线转向点</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("turning_points")]
            public Point[]? TurningPoints { get; set; }
        }

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
                /// <para>行高，单位 px</para>
                /// <para>必填：否</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("row_sizes")]
                public float[]? RowSizes { get; set; }

                /// <summary>
                /// <para>列宽，单位 px</para>
                /// <para>必填：否</para>
                /// <para>最大长度：1000000</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("col_sizes")]
                public float[]? ColSizes { get; set; }

                /// <summary>
                /// <para>整个表格的样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("style")]
                public StyleSuffix? Style { get; set; }

                /// <summary>
                /// <para>整个表格的文字样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text")]
                public TextSuffix? Text { get; set; }
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
                public TextSuffix? Text { get; set; }

                /// <summary>
                /// <para>单元格样式，设置后会覆盖表格样式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("style")]
                public StyleSuffix? Style { get; set; }
            }
        }

        /// <summary>
        /// <para>图形是否锁定，锁定后无法编辑图形，默认false</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// <para>图形在兄弟节点中的层级，层级大的会覆盖层级小的</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：10000</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("z_index")]
        public int? ZIndex { get; set; }

        /// <summary>
        /// <para>生命对象属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lifeline")]
        public WhiteboardNodeLifeline? Lifeline { get; set; }

        /// <summary>
        /// <para>生命对象属性</para>
        /// </summary>
        public record WhiteboardNodeLifeline
        {
            /// <summary>
            /// <para>生命线长度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// <para>最大值：1000000000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("size")]
            public float? Size { get; set; }

            /// <summary>
            /// <para>生命线类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：actor_lifeline</para>
            /// <para>最大长度：1000000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>画笔属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("paint")]
        public WhiteboardNodePaint? Paint { get; set; }

        /// <summary>
        /// <para>画笔属性</para>
        /// </summary>
        public record WhiteboardNodePaint
        {
            /// <summary>
            /// <para>画笔类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：marker</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>marker：马克笔</item>
            /// <item>highlight：高亮笔</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>画板线段，由系列坐标点表示</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("lines")]
            public Point[]? Lines { get; set; }

            /// <summary>
            /// <para>画笔粗细，单位px</para>
            /// <para>必填：否</para>
            /// <para>示例值：7</para>
            /// <para>最大值：23</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("width")]
            public int? Width { get; set; }

            /// <summary>
            /// <para>画笔颜色</para>
            /// <para>必填：否</para>
            /// <para>示例值：#ffffff</para>
            /// <para>最大长度：7</para>
            /// <para>最小长度：7</para>
            /// </summary>
            [JsonPropertyName("color")]
            public string? Color { get; set; }
        }

        /// <summary>
        /// <para>svg图形属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("svg")]
        public WhiteboardNodeSvg? Svg { get; set; }

        /// <summary>
        /// <para>svg图形属性</para>
        /// </summary>
        public record WhiteboardNodeSvg
        {
            /// <summary>
            /// <para>svg 代码</para>
            /// <para>必填：否</para>
            /// <para>示例值：&lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" stroke="black" stroke-width="2" fill="red" /&gt;&lt;/svg&gt;</para>
            /// <para>最大长度：10000000000000000</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("svg_code")]
            public string? SvgCode { get; set; }
        }

        /// <summary>
        /// <para>便签图形属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sticky_note")]
        public WhiteboardNodeStickyNote? StickyNote { get; set; }

        /// <summary>
        /// <para>便签图形属性</para>
        /// </summary>
        public record WhiteboardNodeStickyNote
        {
            /// <summary>
            /// <para>用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：12345678</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>是否展示用户信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("show_author_info")]
            public bool? ShowAuthorInfo { get; set; }
        }

        /// <summary>
        /// <para>思维导图节点属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mind_map_node")]
        public WhiteboardNodeMindMapNode? MindMapNode { get; set; }

        /// <summary>
        /// <para>思维导图节点属性</para>
        /// </summary>
        public record WhiteboardNodeMindMapNode
        {
            /// <summary>
            /// <para>思维导图节点的父节点，必须为思维导图节点</para>
            /// <para>必填：是</para>
            /// <para>示例值：z1:1</para>
            /// <para>最大长度：10000000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string ParentId { get; set; } = string.Empty;

            /// <summary>
            /// <para>思维导图节点图形类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：mind_map_text</para>
            /// <para>可选值：<list type="bullet">
            /// <item>mind_map_text：思维导图文本节点类型</item>
            /// <item>mind_map_full_round_rect：思维导图全圆角矩形节点类型</item>
            /// <item>mind_map_round_rect：思维导图矩形节点类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>思维导图节点在兄弟节点中的位置index</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：10000</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("z_index")]
            public int? ZIndex { get; set; }

            /// <summary>
            /// <para>子节点相对根节点的方向（根节点下的子节点设置才生效）</para>
            /// <para>必填：否</para>
            /// <para>示例值：left</para>
            /// <para>可选值：<list type="bullet">
            /// <item>left：思维导图节点在根节点左侧</item>
            /// <item>right：思维导图节点在根节点右侧</item>
            /// <item>up：思维导图节点在根节点上方</item>
            /// <item>down：思维导图节点在根节点下方</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("layout_position")]
            public string? LayoutPosition { get; set; }

            /// <summary>
            /// <para>子节点列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("children")]
            public string[]? Children { get; set; }
        }

        /// <summary>
        /// <para>思维导图根节点属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mind_map_root")]
        public WhiteboardNodeMindMapRoot? MindMapRoot { get; set; }

        /// <summary>
        /// <para>思维导图根节点属性</para>
        /// </summary>
        public record WhiteboardNodeMindMapRoot
        {
            /// <summary>
            /// <para>思维导图布局方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：left_right</para>
            /// <para>可选值：<list type="bullet">
            /// <item>up_down：上下布局</item>
            /// <item>left_right：左右布局</item>
            /// <item>tree_left：左树布局</item>
            /// <item>tree_right：右树布局</item>
            /// <item>tree_balance：左右交替平衡树布局</item>
            /// <item>vertical_time_line：垂直时间线布局</item>
            /// <item>horizontal_time_line：水平时间线布局</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("layout")]
            public string? Layout { get; set; }

            /// <summary>
            /// <para>思维导图根节点图形类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：mind_map_round_rect</para>
            /// <para>可选值：<list type="bullet">
            /// <item>mind_map_text：思维导图文本节点类型</item>
            /// <item>mind_map_full_round_rect：思维导图全圆角矩形节点类型</item>
            /// <item>mind_map_round_rect：思维导图矩形节点类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>思维导图图形连接线样式</para>
            /// <para>必填：否</para>
            /// <para>示例值：round_angle</para>
            /// <para>可选值：<list type="bullet">
            /// <item>curve：曲线</item>
            /// <item>right_angle：直角折线</item>
            /// <item>round_angle：圆角折线</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("line_style")]
            public string? LineStyle { get; set; }

            /// <summary>
            /// <para>思维导图上布局子节点关系树</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("up_children")]
            public string[]? UpChildren { get; set; }

            /// <summary>
            /// <para>思维导图下布局子节点关系树</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("down_children")]
            public string[]? DownChildren { get; set; }

            /// <summary>
            /// <para>思维导图左布局子节点关系树</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1000000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("left_children")]
            public string[]? LeftChildren { get; set; }

            /// <summary>
            /// <para>思维导图右布局子节点关系树</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("right_children")]
            public string[]? RightChildren { get; set; }
        }
    }

    /// <summary>
    /// <para>文字</para>
    /// </summary>
    public record TextSuffix
    {
        /// <summary>
        /// <para>文字内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：文字内容</para>
        /// <para>最大长度：1024</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

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
        /// <para>文字大小，单位 px，默认为 14 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：14</para>
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

        /// <summary>
        /// <para>文字颜色，16 进制 rgb 值</para>
        /// <para>必填：否</para>
        /// <para>示例值：#6db5a3</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：7</para>
        /// </summary>
        [JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// <para>文字背景色，16 进制 rgb 值</para>
        /// <para>必填：否</para>
        /// <para>示例值：#6db5a3</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：7</para>
        /// </summary>
        [JsonPropertyName("text_background_color")]
        public string? TextBackgroundColor { get; set; }

        /// <summary>
        /// <para>是否存在删除线</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("line_through")]
        public bool? LineThrough { get; set; }

        /// <summary>
        /// <para>是否存在下划线</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("underline")]
        public bool? Underline { get; set; }

        /// <summary>
        /// <para>是否斜体</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("italic")]
        public bool? Italic { get; set; }

        /// <summary>
        /// <para>文字旋转角度，单位度</para>
        /// <para>必填：否</para>
        /// <para>示例值：90</para>
        /// <para>最大值：270</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：文字旋转角度0度</item>
        /// <item>90：文字旋转角度90度</item>
        /// <item>180：文字旋转角度180度</item>
        /// <item>270：文字旋转角度270度</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("angle")]
        public int? Angle { get; set; }

        /// <summary>
        /// <para>文字颜色主题配色编码值</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：100</para>
        /// <para>最小值：-2</para>
        /// </summary>
        [JsonPropertyName("theme_text_color_code")]
        public int? ThemeTextColorCode { get; set; }

        /// <summary>
        /// <para>文字背景颜色主题配色编码值</para>
        /// <para>必填：否</para>
        /// <para>示例值：-1</para>
        /// <para>最大值：100</para>
        /// <para>最小值：-2</para>
        /// </summary>
        [JsonPropertyName("theme_text_background_color_code")]
        public int? ThemeTextBackgroundColorCode { get; set; }
    }

    /// <summary>
    /// <para>样式</para>
    /// </summary>
    public record StyleSuffix
    {
        /// <summary>
        /// <para>填充颜色，16 进制 rbg 值</para>
        /// <para>必填：否</para>
        /// <para>示例值：#6db5a3</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：7</para>
        /// </summary>
        [JsonPropertyName("fill_color")]
        public string? FillColor { get; set; }

        /// <summary>
        /// <para>填充透明度，百分比</para>
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
        /// <item>bold：粗</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("border_width")]
        public string? BorderWidth { get; set; }

        /// <summary>
        /// <para>边框透明度，百分比</para>
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

        /// <summary>
        /// <para>边框颜色，16 进制 rgb 值</para>
        /// <para>必填：否</para>
        /// <para>示例值：#6db5a3</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：7</para>
        /// </summary>
        [JsonPropertyName("border_color")]
        public string? BorderColor { get; set; }

        /// <summary>
        /// <para>填充颜色主题配色编码值</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// <para>最大值：100</para>
        /// <para>最小值：-2</para>
        /// </summary>
        [JsonPropertyName("theme_fill_color_code")]
        public int? ThemeFillColorCode { get; set; }

        /// <summary>
        /// <para>边框颜色主题配色编码值</para>
        /// <para>必填：否</para>
        /// <para>示例值：4</para>
        /// <para>最大值：100</para>
        /// <para>最小值：-2</para>
        /// </summary>
        [JsonPropertyName("theme_border_color_code")]
        public int? ThemeBorderColorCode { get; set; }
    }

    /// <summary>
    /// <para>坐标</para>
    /// </summary>
    public record Point
    {
        /// <summary>
        /// <para>点位置x坐标，单位 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// <para>最大值：1000000000000000000</para>
        /// <para>最小值：-1000000000000000000</para>
        /// </summary>
        [JsonPropertyName("x")]
        public float? X { get; set; }

        /// <summary>
        /// <para>点位置y坐标，单位 px</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// <para>最大值：100000000000000000000</para>
        /// <para>最小值：-10000000000000000000</para>
        /// </summary>
        [JsonPropertyName("y")]
        public float? Y { get; set; }
    }

    /// <summary>
    /// <para>连接</para>
    /// </summary>
    public record ConnectorAttachedObject
    {
        /// <summary>
        /// <para>连接图形的 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：o1:1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>连接图形的方向</para>
        /// <para>必填：否</para>
        /// <para>示例值：auto</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>auto：连接方向自动匹配</item>
        /// <item>top：连接图形顶部方向</item>
        /// <item>right：连接图形右边方向</item>
        /// <item>bottom：连接图形底部方向</item>
        /// <item>left：连接图形左边方向</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("snap_to")]
        public string? SnapTo { get; set; }

        /// <summary>
        /// <para>连接图形的相对坐标，0-1</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("position")]
        public Point? Position { get; set; }
    }
}
