// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除多条记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 删除多条记录 请求体
/// <para>接口ID：6952707657162620930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": [
        "recwNXzPQv"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}