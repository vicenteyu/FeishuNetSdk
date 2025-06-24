// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EmployeesBpsBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询员工 HRBP / 属地 BP 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询员工 HRBP / 属地 BP 请求体
/// <para>接口ID：7261860942295580674</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-bp%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesBpsBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ],
    "get_all": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesBpsBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}