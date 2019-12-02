# AEPB
* Assumption : 
  1. 使用int 作为amount
  2. 没有提供无参的构造方法（aircoin必须有值）
  3. 假设了创建失败的异常
* Question：
  1. 需要工厂类来创建一个coin？
  2. 需要一种处理异常的方式？
  3. 需要改一下项目结构？
  4. 一个aircoin 创建之后amount是否不可改变


1.
given 一辆车，一个Parkinglot，有空位
when 停车
then 停车成功,返回一个ticket

2.
given 一辆车，一个Parkinglot，没有空位，
when 停车
then 停车失败,提示：没有空位了

3.
given 一个Parkinglot，一个ticket
when 取车
then 取车成功,返回ticket对应的车

4.
given 一个Parkinglot，一个无效的ticket
when 取车
then 取车失败