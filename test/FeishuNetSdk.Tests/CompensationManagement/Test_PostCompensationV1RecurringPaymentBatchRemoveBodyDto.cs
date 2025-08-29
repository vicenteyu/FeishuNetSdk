// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="Test_PostCompensationV1RecurringPaymentBatchRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量删除经常性支付记录 请求体
/// <para>接口ID：7441804833880260612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_remove</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1RecurringPaymentBatchRemoveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record_ids": [
        "7397033607132351532"
    ],
    "reason": "删除错误创建的数据"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1RecurringPaymentBatchRemoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}