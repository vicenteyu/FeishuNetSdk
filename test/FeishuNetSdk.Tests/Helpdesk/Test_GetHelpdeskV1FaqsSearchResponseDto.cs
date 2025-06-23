namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 搜索知识库 响应体
/// <para>接口ID：6955768699895808002</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fsearch</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1FaqsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "has_more": false,
    "items": [
      {
        "answer": "建议根据公司实际情况编写，以文档形式答疑",
        "answer_richtext": [
          {
            "content": "建议根据公司实际情况编写，以文档形式答疑",
            "type": "text"
          }
        ],
        "categories": [
          {
            "category_id": "6975057629039083524",
            "id": "6975057629039083524",
            "name": "行政"
          },
          {
            "category_id": "6986214055581122561",
            "id": "6986214055581122561",
            "name": "名片申请"
          }
        ],
        "create_time": 1626604715,
        "create_user": {
          "avatar_url": "https://xxxxx",
          "id": "ou_f7dab73dda407c7cbc947bbf4fd49c45",
          "name": "陈xxx"
        },
        "faq_id": "6986214054851346434",
        "helpdesk_id": "6946124090457505820",
        "id": "6986214054851346434",
        "question": "盒餐发放位置查询",
        "tags": [
          "盒饭",
          "盒餐"
        ],
        "update_time": 1631242057,
        "update_user": {
          "avatar_url": "xxxxxxxxxx",
          "id": "ou_43771a6f8dfa0815600a949779xxx",
          "name": "戴xx"
        }
      },
      {
        "answer": "建议根据公司实际情况编写，以文档形式答疑",
        "answer_richtext": [
          {
            "content": "我的答案",
            "type": "text"
          }
        ],
        "categories": [
          {
            "category_id": "6975057629039083524",
            "id": "6975057629039083524",
            "name": "行政"
          },
          {
            "category_id": "6986214054805159937",
            "id": "6986214054805159937",
            "name": "餐饮服务"
          }
        ],
        "create_time": 1626604715,
        "create_user": {
          "avatar_url": "xxxxxxxxxx",
          "id": "xxxx",
          "name": "陈xx"
        },
        "faq_id": "6986214054826147841",
        "helpdesk_id": "6946124090457505820",
        "id": "6986214054826147841",
        "question": "下午茶推送和选品推荐",
        "tags": [
          "供餐",
          "下午茶"
        ],
        "update_time": 1630063323,
        "update_user": {
          "avatar_url": "xxxxxxxxxx",
          "id": "ou_eb208c4799a1f3a86c12e0b03e5a54b1",
          "name": "蔡xx"
        }
      }
    ],
    "page_size": 2,
    "page_token": "6986214054876479490",
    "total": 2
  },
  "msg": "ok"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1FaqsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}