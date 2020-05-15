﻿namespace Netnr.TencentAI.Static
{
    /// <summary>
    /// 字典
    /// </summary>
    public class Dic
    {
        /// <summary>
        /// 图片识别>场景识别（场景标识定义）
        /// </summary>
        /// <returns></returns>
        public static string Vision_Scener_Label()
        {
            return "机场,机舱,机场航站楼,胡同,游乐场,游乐园,公寓大楼外,水族馆,渡槽,游乐中心,考古发掘,档案文件,曲棍球,性能,牛仔竞技比赛,陆军基地,艺术画廊,艺术学校,艺术工作室,装配线,户外田径场地,阁楼,大礼堂,汽车厂,汽车展厅,荒地,商店,外部,内部,球坑,舞厅,竹林,银行金库,宴会厅,酒吧,棒球场,地下室,室内篮球场,浴室,室内市场,户外市场,海滩,美容院,卧室,泊位,生物学实验室,木板路,船的甲板上,船屋,书店,公用电话亭里面,植物园,室内的弓形窗,保龄球馆,拳击台,桥,建筑立面,斗牛场,车内,公交车站内,肉店,巴特,小屋内,自助餐厅,营地,校园,自然的,城市的,糖果店,峡谷,汽车内饰,旋转木马,城堡,地下墓穴,墓地,化学实验室,孩子的房间,礼堂内,礼堂外,教室,悬崖,衣柜,服装店,海岸,驾驶舱,咖啡店,电脑室,会议室,施工现场,玉米田,畜栏,走廊,庭院,小溪,决口,人行横道,水坝,熟食店,百货商店,沙,植被,沙漠公路,路边小饭店,餐厅,餐厅,迪斯科舞厅,宿舍,市中心,更衣室,车道,药店,门,电梯大堂,电梯井,发动机室,室内自动扶梯,开挖,布艺店,农场,快餐店,栽培,野生的,场路,火灾逃生,消防站,鱼塘,室内跳蚤市场,室内花店,美食广场,足球场,阔叶,森林的小路,林道,正式的花园,喷泉,厨房,车库内,车库外,加油站,外部,杂货店内,礼品店,冰川,高尔夫球场,温室内,温室外,石窟,体育馆内,飞机棚内,飞机棚外,港,五金店,海菲尔德,直升机场,公路,家庭办公室,医院的房间,温泉,酒店外,酒店房间,房子,冰淇淋店,浮冰,冰架,室内溜冰场,室外溜冰场,冰山,工业区,胰岛,浴缸里,监狱,日本花园,珠宝店,垃圾场,城堡,狗屋外面,幼儿园的教室,厨房,泻湖,自然的,垃圾填埋,降落甲板,草坪,图书馆室内,灯塔,客厅,大堂,更衣室,商店外面,商店里面,沼泽,武术馆,水,清真寺外面,山,山间小道,山上的雪,电影院室内,博物馆室内,音乐工作室,自然历史博物馆,婴儿室,海洋,办公室,办公隔间,石油钻台,操作室,果园,乐池,宝塔,宫殿,食品贮藏室,公园,室内停车场,停车场,牧场,亭阁,宠物店,药房,电话亭,码头,比萨店,操场,广场,池塘,酒馆内,赛马场,滚道,筏,铁路轨道,雨林,接待,娱乐室,修理店,餐厅,餐厅厨房,餐厅的露台,稻田,河,岩拱,索桥,废墟,沙盒,桑拿,服务器机房,鞋店,大商场室内,淋浴,滑雪度假村,天空,摩天大楼,雪地,足球场,稳定的,棒球,足球,室内舞台,户外舞台,楼梯,街道,地铁站台,超市,寿司店,沼泽,游泳池,室内游泳池,户外游泳池,电视演播室,亚洲,王座室,售票厅,修剪花园,塔,玩具店,列车内部,火车站台,林场,树屋,沟槽,苔原,海洋的深处,实用的房间,山谷,植物园,兽医办公室,高架桥,村庄,葡萄园,火山,户外排球场,水上公园,水塔,瀑布,浇水洞,波动,小麦田,风电场,院子,禅园".Split(',').ToJson();
        }

        /// <summary>
        /// 图片识别>物体识别（物体标识定义）
        /// </summary>
        /// <returns></returns>
        public static string Vision_Objectr_Label()
        {
            return "鲤鱼,金鱼,大白鲨,虎鲨,锤头鲨,电鳗,黄貂鱼,公鸡,母鸡,鸵鸟,燕雀,金翅雀,朱雀,雪鸟,雀鸟,美洲知更鸟,鹎,松鸦,喜鹊,山雀,河鸟,风筝,秃头鹰,秃鹫,大灰猫头鹰,欧洲火蝾螈,蝾螈,水蜥蜴,斑点蝾螈,美西螈,牛蛙,树蛙,尾蟾,红海龟,棱皮龟,泥龟,鳖,箱龟,条纹壁虎,绿鬣蜥,美国变色龙,鞭尾蜥蜴,飞龙科蜥蜴,皱褶蜥蜴,鳄蜥,毒蜥,绿蜥蜴,非洲变色龙,科莫多龙,非洲鳄鱼,美国短吻鳄,三角龙,雷霆蛇,环颈蛇,猪鼻蛇,绿蛇,大王蛇,乌梢蛇,水蛇,藤蛇,夜蛇,蟒蛇,岩蟒,印度眼镜蛇,曼巴蛇,海蛇,角蝰,响尾蛇,角响尾蛇,三叶虫,喜蛛,蝎子,金园蛛,仓蜘,园蛛,黑寡妇,狼蛛,狼蛛,扁虱,蜈蚣,黑琴鸡,雷鸟,鹧鸪,草原鸡,孔雀,鹌鹑,鹧鸪,非洲灰鹦鹉,金刚鹦鹉,葵花凤头鹦鹉,吸蜜鹦鹉,鸦鹃,蜂虎,犀鸟,蜂鸟,食虫鸟,巨嘴鸟,公鸭,红胸秋沙鸭,鹅,黑天鹅,塔斯克,食蚁兽,鸭嘴兽,袋鼠,考拉,袋熊,水母,海葵,脑珊瑚,扁虫扁形动物,线虫,海螺,蜗牛,鼻涕虫,裸鳃海蛞蝓,石鳖,鹦鹉螺,珍宝蟹,岩石蟹,招潮蟹,皇帝蟹,美国龙虾,龙虾,小龙虾,寄居蟹,等足目动物,白鹳,黑鹳,琵鹭,火烈鸟,小蓝鹭,大白鹭,麻鸦,鹤,锦鸡,欧洲水鸡,美国黑鸭,鸨,翻石鹬,红背鹬,红脚鹬,半蹼鹬,蛎鹬,鹈鹕,帝企鹅,大海鸟,灰鲸,虎鲸,儒艮,海狮,墨西哥狗,日本猎犬,马尔济斯犬,哈巴狗,狮子狗,布莱尼姆猎犬,巴比,玩具犬,罗得西亚脊背犬,阿富汗猎犬,猎犬,比格犬,侦探猎犬,蓝斑猎狗,猎浣熊犬,沃克犬,英国猎狐犬,美洲赤狗,俄罗斯猎狼犬,爱尔兰猎狼犬,意大利灵缇犬,惠比特犬,依比沙猎犬,挪威猎犬,奥达猎犬,沙克犬瞪羚猎犬,苏格兰猎鹿犬,威玛猎犬,斯塔福德郡斗牛犬,美国斗牛犬,贝德灵顿犬,博德猎狐犬,凯丽蓝犬,爱尔兰犬,诺福克犬,诺维奇犬,约克郡犬,刚毛猎狐犬,莱克兰犬,锡利哈姆犬,艾尔谷犬,凯恩犬,澳大利亚犬,英国小猎犬,波士顿犬,迷你雪纳瑞,巨型雪纳瑞,标准雪纳瑞,苏格兰犬,菊花狗,丝毛狗,爱尔兰软毛犬,西部高地白犬,拉萨，拉萨犬,平滑毛寻回犬,卷毛寻回犬,金毛猎犬,拉布拉多猎犬,乞沙比克猎犬,德国短毛猎犬,匈牙利维兹拉犬,英国赛特犬,爱尔兰塞特猎犬,戈登雪达犬,布列塔尼犬,黄毛猎犬,英国史宾格犬,威尔士激飞猎犬,英国可卡犬,萨塞克斯猎犬,爱尔兰水猎犬,哥威斯犬,舒柏奇犬,牧羊犬,马里努阿犬,伯瑞犬,澳大利亚护羊犬,可蒙犬,英国牧羊犬,喜乐蒂牧羊犬,牧羊犬,边境牧羊犬,法兰德斯畜牧犬,罗威犬,德国牧羊犬,杜宾犬,迷你杜宾犬,大瑞士山犬,伯恩山犬,阿彭策尔勒犬,恩特雷布赫山犬,拳狮犬,斗牛獒犬,藏獒,法国斗牛犬,大丹犬,圣伯纳德狗,爱斯基摩犬,雪橇犬,西伯利亚雪橇犬,达尔马提亚,猴犬,巴辛吉,哈巴狗,兰伯格犬,纽芬兰犬,大白熊犬,萨摩犬,博美犬,松狮犬,荷兰毛狮犬,布鲁塞尔格林芬犬,潘布魯克威尔斯柯基犬,卡迪根威尔士柯基犬,玩具型贵宾犬,迷你型贵宾犬,标准型贵宾犬,墨西哥无毛犬,灰狼,白狼,红狼,草原狼,澳洲野犬,豺狗,三色犬,鬣狗,红狐狸,美洲小狐,北极狐,灰色的狐狸,虎斑,猫虎,波斯猫,暹罗暹罗猫,埃及猫,美洲狮,猞猁,豹,雪豹,美洲虎,狮子,虎,猎豹,棕熊,黑熊,北极熊,懒熊,猫鼬,狐獴,虎甲虫,瓢虫,地面甲虫,天牛,叶甲,粪甲虫,犀甲虫,象甲,飞,蜜蜂,蚂蚁,蚱蜢,蟋蟀,竹节虫,蟑螂,螳螂,蝉,叶蝉,中华草蛉,蜻蜓，大蚊,豆娘,花蝶,小环蝴蝶,帝王蝶,菜粉蝶,硫蝴蝶,灰蝶,海星,海胆,海参,木兔,野兔,兔,仓鼠,刺猬,东方狐松鼠,土拨鼠,海狸,豚鼠,酢浆草,斑马,猪,野猪,疣猪,河马,公牛,水牛,野牛,公羊,大角羊,山羊,狷羚,黑斑羚,瞪羚,阿拉伯骆驼,美洲驼,黄鼠狼,水貂,艾鼬,黑足鼬,水獭,臭鼬,獾,犰狳,三趾树懒,猩猩,大猩猩,黑猩猩,长臂猿,合趾猿长臂猿,长尾猴,猴子,狒狒,猕猴,叶猴,疣,长鼻猴,狨,浣熊,吼猴,伶猴,蜘蛛猴,松鼠猴,马达加斯加猫,大狐猴,印度大象,非洲大象,小熊猫,熊猫,杖鱼,鳗鱼,银大马哈鱼,三色刺蝶鱼,海葵鱼,鲟鱼,雀鳝,狮子鱼,河豚,算盘,长袍,学位袍,手风琴,原声吉他,航母,客机,飞船,祭坛,救护车,水陆两用飞机构,模拟时钟,蜂房,围裙,垃圾桶,突击步枪,背包,面包店,平衡梁,气球,圆珠笔,创可贴,班卓琴,栏杆,杠铃,理发椅,理发店,谷仓,气压计,木桶,手推车,棒球,篮球,摇篮,巴松管,游泳帽,浴巾,浴缸,沙滩车,灯塔,烧杯,熊皮,啤酒瓶,啤酒杯,钟架,围兜,双坐自行车,比基尼,粘合剂,望远镜,鸟舍,船屋,雪橇,波洛领带,阀盖,书柜,书店,瓶盖,弓,领结,黄铜,文胸,码头,盾牌,扫帚,水桶,搭扣,防弹背心,子弹列车,肉店,出租车,釜,蜡烛,大炮,独木舟,开罐器,开衫,车镜,旋转木马,木匠工具箱,纸箱,汽车轮,提款机,盒式录音带,磁带播放器,城堡,双体船,播放器,大提琴,蜂窝电话,链,围栏,邮件,油锯,胸部,衣柜,编钟,瓷器柜,圣诞袜,教堂,电影院,切肉刀,崖居,斗篷,木鞋,鸡尾酒调酒器,咖啡杯,咖啡壶,线圈,密码锁,电脑键盘,糖果,集装箱船,可转换,螺旋形的,喇叭,牛仔靴,牛仔帽,摇篮,起重机,头盔,箱,婴儿床,瓦罐锅,槌球,拐杖,胸甲,堤坝,书桌,台式电脑,拨号电话,尿布,数字时钟,数字手表,餐桌,抹布,洗碗机,盘式制动器,码头,狗拉雪橇,拱顶,门垫,钻井平台,鼓,鼓槌,哑铃,荷兰烤箱,电风扇,电吉他,电力机车,娱乐中心,信封,咖啡机,香粉,蟒蛇,文件,消防船,消防车,火屏,旗杆,长笛,折叠椅,橄榄球头盔,叉车,喷泉,钢笔,四柱,货运车,号角,煎锅,毛皮大衣,垃圾车,防毒面具,气泵,高脚杯,卡丁车,高尔夫球,高尔夫球车,贡多拉,锣,长袍,大钢琴,苗圃,格栅,杂货店,断头台,幻灯片,头发喷雾,半轨,铁锤,阻碍,手吹风,掌上电脑,手帕,硬盘,口风琴,竖琴,收割机,斧头,皮套,家庭影院,蜂窝,钩爪,衬裙,单杠,马车,沙漏,音乐播放器,铁,南瓜灯,牛仔裤,吉普车,T恤,拼图游戏,黄包车,操纵杆,和服,护膝,结,实验室工作服,钢包,灯罩,笔记本电脑,割草机,镜头盖,开信刀,图书馆,救生艇,打火机,豪华轿车,班轮,口红,拖鞋,洗剂,扬声器,放大镜,锯木厂,磁罗盘,邮袋,信箱,紧身衣,背带式女浴衣,窨井盖,沙球,马林巴木琴,面具,火柴,花柱,迷宫,测量杯,药箱,巨石,麦克风,微波炉,军装,奶瓶,小巴士,迷你裙,面包车,导弹,手套,搅拌碗,制造家,模型,调制解调器,修道院,监控,助力车,砂浆,学位帽,清真寺,蚊帐,摩托车,山地自行车,登山帐,鼠标,捕鼠器,移动车,枪口,指甲,颈托,项链,乳头,笔记本电脑,方尖碑,双簧管双簧管,陶笛,里程表,滤油器,风琴,示波器,罩裙,牛车,氧气面罩,小包裹,桨,明轮,挂锁,画笔,睡衣,宫殿,排箫,纸巾,降落伞,双杠杆,公园的长椅,停车收费表,客车,露台,付费电话,底座,铅笔盒,卷笔刀,香水,培养皿,复印机,挑,头盔,栅栏,皮卡,码头,储蓄银行,药瓶,枕头,乒乓球,风车,海盗船,水罐,飞机,天文馆,塑料袋,板架,犁,柱塞,宝丽来相机,极,警车,雨披,台球桌,汽水瓶,花盆,陶工的轮子,电钻,祈祷毯,打印机,监狱,导弹,投影机,冰球,沙包,钱包,羽毛笔,被子,赛车,球拍,散热器,无线电,无线电望远镜,雨桶,休闲车,卷轴,反射式照相机,冰箱,远程遥控,餐厅,左轮手枪,步枪,摇椅,烤肉店,橡皮,橄榄球,标尺,跑步鞋,保险箱,别针,盐瓶,凉鞋,布裙,萨克斯管,剑鞘,秤,校车,帆船,记分牌,屏幕,螺丝钉,螺丝刀,安全带,缝纫机,小圆盾,鞋店,障子,购物篮,购物车,铲子,淋浴帽,浴帘,滑雪,滑雪面罩,睡袋,计算尺,滑动门,赌博机,通气管,雪橇,扫雪机,皂液器,足球,短袜,太阳能盘,宽边帽,一碗汤,空格键,空间加热器,航天飞机,铲,快艇,蜘蛛网,主轴,跑车,聚光灯,舞台,蒸汽机车,钢拱桥,钢鼓,听诊器,长巾,石头墙,秒表,火炉,过滤器,有轨电车,担架,工作室沙发,佛塔,潜艇,西服,日晷,太阳镜,墨镜,防晒霜,悬索桥,拖把,运动衫,游泳裤,摆动,开关,注射器,台灯,坦克,磁带播放器,茶壶,泰迪熊,电视系统,网球,茅草屋顶,剧场幕布,顶针,脱粒机,宝座,瓦屋顶,烤面包机,烟草店,马桶座,火炬,图腾柱,拖车,玩具店,拖拉机,拖车,托盘,风衣,三轮车,三体船,三脚架,凯旋门,无轨电车,长号,浴缸,十字转门,打字机键盘,雨伞,独轮车,立式钢琴,真空吸尘器,花瓶,拱顶,天鹅绒,自动售货机,法衣,高架桥,小提琴,排球,松饼机,墙上的时钟,钱包,衣柜,军用飞机,洗脸盆,洗衣机,一瓶水,水壶,水塔,威士忌的壶,吹口哨,假发,纱窗,百叶窗,温莎领带,酒瓶,翼,炒锅,木勺子,羊毛,蠕虫围栏,沉船,快艇,蒙古包,网站,漫画书,纵横填字谜,街道标志,交通信号灯,皮书套,菜单,盘子,鳄梨酱,清汤,火锅,琐事,冰淇淋,雪糕,法国面包,百吉饼,椒盐脆饼,芝士汉堡,热狗,土豆泥,结球甘蓝,西兰花,菜花,西葫芦,意大利南瓜,小青南瓜,南瓜,黄瓜,朝鲜蓟,甜椒,刺棘蓟,蘑菇,澳洲青苹,草莓,橙色,柠檬,无花果,菠萝,香蕉,木菠萝,蛋奶冻苹果,石榴,干草,培根,巧克力酱,面团,瑞士肉包,比萨派,馅饼,玉米煎饼,红葡萄酒,意大利浓咖啡,杯子,蛋奶酒,高山,气泡,悬崖,珊瑚礁,间歇泉,湖边,海角,沙洲,海岸,谷,火山,棒球运动员,新郎,潜水员,油菜,雏菊,黄色凤仙花,玉米,橡子,玫瑰果,七叶树,珊瑚菌,木耳,鹿花菌属,鬼笔菌,地星,灰树花,牛肝菌,穗,卫生纸".Split(',').ToJson();
        }

        /// <summary>
        /// 图片特效>图片滤镜（天天P图）,更适合人物图片（预设滤镜效果编码）
        /// </summary>
        /// <returns></returns>
        public static string Ptu_ImgFilter_Filter()
        {
            return "[{\"id\":1,\"name\":\"黛紫\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/1.png\"},{\"id\":2,\"name\":\"岩井\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/2.png\"},{\"id\":3,\"name\":\"粉嫩\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/3.png\"},{\"id\":4,\"name\":\"错觉\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/4.png\"},{\"id\":5,\"name\":\"暖阳\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/5.png\"},{\"id\":6,\"name\":\"浪漫\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/6.png\"},{\"id\":7,\"name\":\"蔷薇\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/7.gif\"},{\"id\":8,\"name\":\"睡莲\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/8.gif\"},{\"id\":9,\"name\":\"糖果玫瑰\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/9.gif\"},{\"id\":10,\"name\":\"新叶\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/10.gif\"},{\"id\":11,\"name\":\"尤加利\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/11.gif\"},{\"id\":12,\"name\":\"墨\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/12.png\"},{\"id\":13,\"name\":\"玫瑰初雪\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/13.png\"},{\"id\":14,\"name\":\"樱桃布丁\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/14.png\"},{\"id\":15,\"name\":\"白茶\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/15.png\"},{\"id\":16,\"name\":\"甜薄荷\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/16.png\"},{\"id\":17,\"name\":\"樱红\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/17.png\"},{\"id\":18,\"name\":\"圣代\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/18.png\"},{\"id\":19,\"name\":\"莫斯科\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/19.png\"},{\"id\":20,\"name\":\"冲绳\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/20.png\"},{\"id\":21,\"name\":\"粉碧\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/21.png\"},{\"id\":22,\"name\":\"地中海\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/22.png\"},{\"id\":23,\"name\":\"首尔\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/23.png\"},{\"id\":24,\"name\":\"佛罗伦萨\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/24.png\"},{\"id\":25,\"name\":\"札幌\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/25.png\"},{\"id\":26,\"name\":\"栀子\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/26.png\"},{\"id\":27,\"name\":\"东京\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/27.png\"},{\"id\":28,\"name\":\"昭和\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/28.png\"},{\"id\":29,\"name\":\"自然\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/29.gif\"},{\"id\":30,\"name\":\"清逸\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/30.png\"},{\"id\":31,\"name\":\"染\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/31.png\"},{\"id\":32,\"name\":\"甜美\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter/32.png\"}]";
        }

        /// <summary>
        /// 图片特效>图片滤镜（AI Lab）,更适合风景图片（预设滤镜效果编码）
        /// </summary>
        /// <returns></returns>
        public static string Vision_ImgFilter_Filter()
        {
            return ",//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/1-01.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/2-03.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/3-04.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/4-07.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/5-08.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/6-09.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/7-11.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/8-12.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/9-13.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/10-16.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/11-17.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/12-19.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/13-28.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/14-30.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/15-65.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/16-80.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/17-87.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/18-125.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/19-149.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/20-154.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/21-172.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/22-176.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/23-206.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/24-207.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/25-215.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/26-225.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/27-226.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/28-239.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/29-246.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/30-326.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/31-334.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/32-340.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/33-348.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/34-350.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/35-356.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/36-357.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/37-359.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/38-391.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/39-394.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/40-418.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/41-420.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/42-430.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/43-451.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/44-453.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/45-727.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/46-10044.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/47-10046.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/48-10047.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/49-10048.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/50-10059.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/51-10060.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/52-10062.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/53-10063.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/54-10066.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/55-10068.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/56-10070.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/57-10100.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/58-10101.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/59-10109.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/60-10123.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/61-10124.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/62-10128.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/63-10134.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/64-10136.jpg,//yyb.gtimg.com/aiplat/ai/upload/doc/imgfilter-ailab/65-10160.jpg".Split(',').ToJson();
        }

        /// <summary>
        /// 图片特效>人脸美妆（人脸美妆编码）
        /// </summary>
        /// <returns></returns>
        public static string Ptu_FaceCosmetic_Cosmetic()
        {
            return "[{\"id\":1,\"type\":\"日系妆\",\"name\":\"芭比粉\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/1.png\"},{\"id\":2,\"type\":\"日系妆\",\"name\":\"清透\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/2.png\"},{\"id\":3,\"type\":\"日系妆\",\"name\":\"烟灰\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/3.png\"},{\"id\":4,\"type\":\"日系妆\",\"name\":\"自然\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/4.png\"},{\"id\":5,\"type\":\"日系妆\",\"name\":\"樱花粉\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/5.png\"},{\"id\":6,\"type\":\"日系妆\",\"name\":\"原宿红\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/6.png\"},{\"id\":7,\"type\":\"韩妆\",\"name\":\"闪亮\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/7.png\"},{\"id\":8,\"type\":\"韩妆\",\"name\":\"粉紫\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/8.png\"},{\"id\":9,\"type\":\"韩妆\",\"name\":\"粉嫩\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/9.png\"},{\"id\":10,\"type\":\"韩妆\",\"name\":\"自然\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/10.png\"},{\"id\":11,\"type\":\"韩妆\",\"name\":\"清透\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/11.png\"},{\"id\":12,\"type\":\"韩妆\",\"name\":\"大地色\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/12.png\"},{\"id\":13,\"type\":\"韩妆\",\"name\":\"玫瑰\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/13.png\"},{\"id\":14,\"type\":\"裸妆\",\"name\":\"自然\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/14.png\"},{\"id\":15,\"type\":\"裸妆\",\"name\":\"清透\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/15.png\"},{\"id\":16,\"type\":\"裸妆\",\"name\":\"桃粉\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/16.png\"},{\"id\":17,\"type\":\"裸妆\",\"name\":\"橘粉\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/17.png\"},{\"id\":18,\"type\":\"裸妆\",\"name\":\"春夏\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/18.png\"},{\"id\":19,\"type\":\"裸妆\",\"name\":\"秋冬\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/19.png\"},{\"id\":20,\"type\":\"主题妆\",\"name\":\"经典复古\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/20.png\"},{\"id\":21,\"type\":\"主题妆\",\"name\":\"性感混血\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/21.png\"},{\"id\":22,\"type\":\"主题妆\",\"name\":\"炫彩明眸\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/22.png\"},{\"id\":23,\"type\":\"主题妆\",\"name\":\"紫色魅惑\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facecosmetic/23.png\"}]";
        }

        /// <summary>
        /// 图片特效>人脸变妆（人脸变妆编码）
        /// </summary>
        /// <returns></returns>
        public static string Ptu_FaceDecoration_Decoration()
        {
            return "[{\"id\":1,\"name\":\"埃及妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/1.jpg\"},{\"id\":2,\"name\":\"巴西土著妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/2.jpg\"},{\"id\":3,\"name\":\"灰姑娘妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/3.jpg\"},{\"id\":4,\"name\":\"恶魔妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/4.jpg\"},{\"id\":5,\"name\":\"武媚娘妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/5.jpg\"},{\"id\":6,\"name\":\"星光薰衣草\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/6.jpg\"},{\"id\":7,\"name\":\"花千骨\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/7.jpg\"},{\"id\":8,\"name\":\"僵尸妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/8.jpg\"},{\"id\":9,\"name\":\"爱国妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/9.jpg\"},{\"id\":10,\"name\":\"小胡子妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/10.jpg\"},{\"id\":11,\"name\":\"美羊羊妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/11.jpg\"},{\"id\":12,\"name\":\"火影鸣人妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/12.jpg\"},{\"id\":13,\"name\":\"刀马旦妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/13.jpg\"},{\"id\":14,\"name\":\"泡泡妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/14.jpg\"},{\"id\":15,\"name\":\"桃花妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/15.jpg\"},{\"id\":16,\"name\":\"女皇妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/16.jpg\"},{\"id\":17,\"name\":\"权志龙\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/17.jpg\"},{\"id\":18,\"name\":\"撩妹妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/18.jpg\"},{\"id\":19,\"name\":\"印第安妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/19.jpg\"},{\"id\":20,\"name\":\"印度妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/20.jpg\"},{\"id\":21,\"name\":\"萌兔妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/21.jpg\"},{\"id\":22,\"name\":\"大圣妆\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facedecoration/22.jpg\"}]";
        }

        /// <summary>
        /// 图片特效>大头贴（大头贴编码）
        /// </summary>
        /// <returns></returns>
        public static string Ptu_FaceSticker_Sticker()
        {
            return "[{\"id\":1,\"name\":\"NewDay\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/1.png\"},{\"id\":2,\"name\":\"欢乐球吃球1\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/2.png\"},{\"id\":3,\"name\":\"Bonvoyage\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/3.jpg\"},{\"id\":4,\"name\":\"Enjoy\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/4.png\"},{\"id\":5,\"name\":\"ChickenSpring\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/5.png\"},{\"id\":6,\"name\":\"ChristmasShow\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/6.png\"},{\"id\":7,\"name\":\"ChristmasSnow\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/7.png\"},{\"id\":8,\"name\":\"CircleCat\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/8.jpg\"},{\"id\":9,\"name\":\"CircleMouse\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/9.jpg\"},{\"id\":10,\"name\":\"CirclePig\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/10.jpg\"},{\"id\":11,\"name\":\"Comicmn\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/11.png\"},{\"id\":12,\"name\":\"CuteBaby\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/12.jpg\"},{\"id\":13,\"name\":\"Envolope\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/13.jpg\"},{\"id\":14,\"name\":\"Fairytale\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/14.jpg\"},{\"id\":15,\"name\":\"GoodNight\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/15.jpg\"},{\"id\":16,\"name\":\"HalloweenNight\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/16.jpg\"},{\"id\":17,\"name\":\"LovelyDay\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/17.jpg\"},{\"id\":18,\"name\":\"Newyear2017\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/18.png\"},{\"id\":19,\"name\":\"PinkSunny\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/19.png\"},{\"id\":20,\"name\":\"KIRAKIRA\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/20.jpg\"},{\"id\":21,\"name\":\"欢乐球吃球2\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/21.jpg\"},{\"id\":22,\"name\":\"SnowWhite\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/22.png\"},{\"id\":23,\"name\":\"SuperStar\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/23.png\"},{\"id\":24,\"name\":\"WonderfulWork\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/24.png\"},{\"id\":25,\"name\":\"Cold\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/25.png\"},{\"id\":26,\"name\":\"狼人杀守卫\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/26.png\"},{\"id\":27,\"name\":\"狼人杀猎人\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/27.png\"},{\"id\":28,\"name\":\"狼人杀预言家\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/28.png\"},{\"id\":29,\"name\":\"狼人杀村民\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/29.png\"},{\"id\":30,\"name\":\"狼人杀女巫\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/30.png\"},{\"id\":31,\"name\":\"狼人杀狼人\",\"image_url\":\"//yyb.gtimg.com/aiplat/ai/upload/doc/facesticker/31.png\"}]";
        }
    }
}