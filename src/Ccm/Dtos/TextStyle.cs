// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="TextStyle.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本样式</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>文本样式</para>
/// </summary>
public record TextStyle
{
    /// <summary>
    /// <para>对齐方式</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：居左排版</item>
    /// <item>2：居中排版</item>
    /// <item>3：居右排版</item>
    /// </list></para>
    /// <para>默认值：1</para>
    /// </summary>
    [JsonPropertyName("align")]
    public int? Align { get; set; }

    /// <summary>
    /// <para>todo 的完成状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("done")]
    public bool? Done { get; set; }

    /// <summary>
    /// <para>文本的折叠状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("folded")]
    public bool? Folded { get; set; }

    /// <summary>
    /// <para>代码块语言</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：PlainText</item>
    /// <item>2：ABAP</item>
    /// <item>3：Ada</item>
    /// <item>4：Apache</item>
    /// <item>5：Apex</item>
    /// <item>6：Assembly Language</item>
    /// <item>7：Bash</item>
    /// <item>8：CSharp</item>
    /// <item>9：C++</item>
    /// <item>10：C</item>
    /// <item>11：COBOL</item>
    /// <item>12：CSS</item>
    /// <item>13：CoffeeScript</item>
    /// <item>14：D</item>
    /// <item>15：Dart</item>
    /// <item>16：Delphi</item>
    /// <item>17：Django</item>
    /// <item>18：Dockerfile</item>
    /// <item>19：Erlang</item>
    /// <item>20：Fortran</item>
    /// <item>21：FoxPro（已废弃）</item>
    /// <item>22：Go</item>
    /// <item>23：Groovy</item>
    /// <item>24：HTML</item>
    /// <item>25：HTMLBars</item>
    /// <item>26：HTTP</item>
    /// <item>27：Haskell</item>
    /// <item>28：JSON</item>
    /// <item>29：Java</item>
    /// <item>30：JavaScript</item>
    /// <item>31：Julia</item>
    /// <item>32：Kotlin</item>
    /// <item>33：LateX</item>
    /// <item>34：Lisp</item>
    /// <item>35：Logo（已废弃）</item>
    /// <item>36：Lua</item>
    /// <item>37：MATLAB</item>
    /// <item>38：Makefile</item>
    /// <item>39：Markdown</item>
    /// <item>40：Nginx</item>
    /// <item>41：Objective-C</item>
    /// <item>42：OpenEdgeABL（已废弃）</item>
    /// <item>43：PHP</item>
    /// <item>44：Perl</item>
    /// <item>45：PostScript（已废弃）</item>
    /// <item>46：Power Shell</item>
    /// <item>47：Prolog</item>
    /// <item>48：ProtoBuf</item>
    /// <item>49：Python</item>
    /// <item>50：R</item>
    /// <item>51：RPG（已废弃）</item>
    /// <item>52：Ruby</item>
    /// <item>53：Rust</item>
    /// <item>54：SAS</item>
    /// <item>55：SCSS</item>
    /// <item>56：SQL</item>
    /// <item>57：Scala</item>
    /// <item>58：Scheme</item>
    /// <item>59：Scratch（已废弃）</item>
    /// <item>60：Shell</item>
    /// <item>61：Swift</item>
    /// <item>62：Thrift</item>
    /// <item>63：TypeScript</item>
    /// <item>64：VBScript</item>
    /// <item>65：Visual Basic</item>
    /// <item>66：XML</item>
    /// <item>67：YAML</item>
    /// <item>68：CMake</item>
    /// <item>69：Diff</item>
    /// <item>70：Gherkin</item>
    /// <item>71：GraphQL</item>
    /// <item>72：OpenGL Shading Language</item>
    /// <item>73：Properties</item>
    /// <item>74：Solidity</item>
    /// <item>75：TOML</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("language")]
    public int? Language { get; set; }

    /// <summary>
    /// <para>代码块是否自动换行</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("wrap")]
    public bool? Wrap { get; set; }

    /// <summary>
    /// <para>块背景色</para>
    /// <para>必填：否</para>
    /// <para>示例值：LightGrayBackground</para>
    /// <para>可选值：<list type="bullet">
    /// <item>LightGrayBackground：浅灰色</item>
    /// <item>LightRedBackground：浅红色</item>
    /// <item>LightOrangeBackground：浅橙色</item>
    /// <item>LightYellowBackground：浅黄色</item>
    /// <item>LightGreenBackground：浅绿色</item>
    /// <item>LightBlueBackground：浅蓝色</item>
    /// <item>LightPurpleBackground：浅紫色</item>
    /// <item>PaleGrayBackground：淡灰色</item>
    /// <item>DarkGrayBackground：深灰色</item>
    /// <item>DarkRedBackground：深红色</item>
    /// <item>DarkOrangeBackground：深橙色</item>
    /// <item>DarkYellowBackground：深黄色</item>
    /// <item>DarkGreenBackground：深绿色</item>
    /// <item>DarkBlueBackground：深蓝色</item>
    /// <item>DarkPurpleBackground：深紫色</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; set; }

    /// <summary>
    /// <para>首行缩进级别</para>
    /// <para>必填：否</para>
    /// <para>示例值：NoIndent</para>
    /// <para>可选值：<list type="bullet">
    /// <item>NoIndent：无缩进</item>
    /// <item>OneLevelIndent：一级缩进</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("indentation_level")]
    public string? IndentationLevel { get; set; }

    /// <summary>
    /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
    /// <para>必填：否</para>
    /// <para>示例值："auto"</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public string? Sequence { get; set; }
}