// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdEnumsByEnumNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自定义枚举详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取自定义枚举详细信息 响应体
/// <para>接口ID：7620858064161918159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-enum/get_enum_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-enum%2fget_enum_detail</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdEnumsByEnumNameResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "name": "enum_name",
        "description": "enum描述",
        "options": [
            "enum_1"
        ],
        "created_at": "1765441837625"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdEnumsByEnumNameResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}