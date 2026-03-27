// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_GetMinutesV1MinutesByMinuteTokenArtifactsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙记AI产物 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 获取妙记AI产物 响应体
/// <para>接口ID：7621494177948142790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/artifacts</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fartifacts</para>
/// </summary>
[TestClass]
public class Test_GetMinutesV1MinutesByMinuteTokenArtifactsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"summary":"妙记总结",
"minute_chapters":[{"title":"项目进度回顾与风险评估",
"start_ms":"31000",
"stop_ms":"33000",
"summary_content":"1. 确认Q3项目交付节点为9月30日，延迟交付将触发合同违约条款；2. 指派张三负责协调供应商资源，需在7月15日前提交资源保障方案；3. 风险预警：核心组件供应链可能存在断供风险，需启动备选供应商评估流程。"}],
"minute_todos":[{
    "content": "提交资源保障方案",
    "assignees": [
        "张三"
    ]
}]}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.GetMinutesV1MinutesByMinuteTokenArtifactsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}