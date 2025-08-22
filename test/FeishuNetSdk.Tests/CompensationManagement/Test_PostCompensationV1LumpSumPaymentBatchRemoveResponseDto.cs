// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1LumpSumPaymentBatchRemoveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除一次性支付记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量删除一次性支付记录 响应体
/// <para>接口ID：7430824932635197444</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_remove</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1LumpSumPaymentBatchRemoveResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "operate_results": [
            {
                "id": "7390583861280556588",
                "unique_id": "7390583861280556588",
                "code": 21270202,
                "message": "uqniue id conflict"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1LumpSumPaymentBatchRemoveResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}