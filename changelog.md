**破坏性更新**

- 所有事件和回调需要实现参数：CancellationToken
- 重新设计事件和回调服务
- 终结点和长连接增加 CancellationToken
- DTO扩展命名空间：FeishuNetSdk.Extensions

**新增**
- 【飞书 aPaaS】执行SQL 接口
- 【飞书 aPaaS】查询数据表数据记录 接口
- 【飞书 aPaaS】向数据表中添加或更新记录 接口
- 【飞书 aPaaS】按条件更新数据表中的记录 接口
- 【飞书 aPaaS】批量更新数据表中的记录 接口
- 【飞书 aPaaS】删除数据表中的记录 接口
- 【飞书 aPaaS】查询视图数据记录 接口

**变更**

- 批量更正一次性支付记录 请求体
- 获取绩效模板配置 响应体


