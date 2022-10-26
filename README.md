# Анализ предметной области

Строительная компания - Юридическое лицо, выполняющее один или несколько видов строительных работ (услуг), способное под свою ответственность выполнить строительные работы (услуги) по заданию заказчика (другой стороны) за определенную плату с использованием собственных материалов или материалов заказчика.

Дизайн проект-это комплексный пакет документов с различными вариантами планировки квартиры/дома, схемами, техническими планами, 3D-визуализацией, иллюстрациями и 
подбором необходимых материалов и меблировки.
* Отделка недвижимости – отделка делиться на демонтаж, черновую отделку, чистовая отделка.
* Демонтаж – процесс подготовки объекта к работам, то есть очищение поверхностей от старых покрытий, снос перегородок и т.д.
* Черновая отделка – является монтаж инженерных систем, также на этом этапе выравнивают стены, пол, потолки.
* Инженерные системы – электропроводка, водоснабжение, канализация, отопление.
* Предчистовая отделка - более тонкое и тщательное выравнивание.
* Чистовая отделка - финальный этап. В квартире клеят обои, красят стены и потолки, укладывают плитку, ламинат или паркет, устанавливают сантехнику, розетки и межкомнатные двери.


# Бизнес-процесс «Работа строительной компании по отделке недвижимости»

По приходу клиента в офис менеджер обрабатывает информацию об объекте и предлагает услуги кампании, после чего направляет на него специалистов. Мастера осматривают предложенный объект и выносят свое решение о возможности вести работы на нём. Если это решение положительно кампания отправляет характеристики и план объекта дизайнеру, после чего если клиента устраивает дизайн-проект мастера заносят в информационную систему необходимые материалы. Информационная система проверяет на наличие необходимые материалы и если они имеются резервирует, если же таковых нет система заказывает их. После того как менеджера уведомили о зарезервированных материалов начинается составление договора о начале ремонтных работ в договор входит:

1\)	тип работы;

2\)	стоимость данной работы;

3\)	стоимость необходимых материалов;

4\)	сроки выполнения работы.

Если клиента устраивает договор, необходимо чтобы он оплати зарезервированные материалы, после чего мастера смогут приступить к работе на этом объекте. 
После работы мастеров происходи контроль выполненной работы, после которого объект отдаётся на осмотр клиенту. Если клиента устраивает выполненная работа, 
то он оплачивает выполненную работу по договору.
Услуги, предоставляемые строительной кампанией: капитальный ремонт, косметический ремонт, евроремонт. 
Каждый из видов ремонта может включать себя широкий спектр услуг: закупку и доставку отделочных и строительных материалов, штукатурные, плиточные, малярные, гипсокартонные и отделочные работы, замену электропроводки, столярные и плиточные работы, работы по гидроизоляции, утеплению и шумоизоляции, установку, полов, натяжных потолков и др. услуги.
## Создание BPMN модели.
BPMN (Business Process Model and Notation) — это язык моделирования бизнес-процессов, который является промежуточным звеном между формализацией/визуализацией и воплощением бизнес-процесса. С помощью моделирования мы можем описать любые бизнес-процессы, и они могут выполняться в самых разных системах управления.
Основная цель BPMN — создание стандартного набора условных обозначений, понятных всем бизнес-пользователям. Бизнес-пользователи включают в себя бизнес-аналитиков, создающих и улучшающих процессы, технических разработчиков, ответственных за реализацию процессов и менеджеров, следящих за процессами и управляющих ими. Следовательно, BPMN призвана служить связующим звеном между фазой дизайна бизнеспроцесса и фазой его реализации.
Элементы нотации BPMN – это элементы графической схемы, но также и элементы самого бизнес-процесса.

Нотация опирается на следующие базовые графические элементы:
• Пул и Дорожки
• Действия
• Шлюзы или Развилки
• События
• Потоки
• Артефакты
![image](https://user-images.githubusercontent.com/105555106/198086321-0ffd73ca-5b05-46df-b635-ca73ad0650b0.png)
## Use case модель
Диаграмма вариантов использования
Диаграмма прецедентов или диаграмма вариантов использования (англ. use case diagram) в UML — диаграмма, отражающая отношения между акторами и прецедентами и являющаяся составной частью модели прецедентов, позволяющей описать систему на концептуальном уровне.

Юзкейсы могут содержать следующие элементы (их количество зависит от сложности сценария):
Актор (actor) — тот, кто использует систему. Если взять за пример онлайн-магазин, там может быть несколько акторов: покупатели, продавцы, компании, занимающиеся доставкой, компании, проводящие платежи.
Стейкхолдер (stakeholder) — тот, кто заинтересован в определенном поведении системы. Зачастую это не конечный пользователь, а кто-то, получающий выгоду от функционирования системы. В случае с онлайн-магазином это может быть партнер — платежная платформа.
Первичное действующее лицо (primary actor) — человек или система, чьи цели достигаются при помощи нашего продукта. В онлайн-магазине это может быть основной дистрибьютор, чьи товары продаются на этой онлайн-платформе.
Предусловия и постусловия — что должно быть в наличии или должно произойти до и после запуска сценария использования.
Триггеры — события, запускающие юзкейс.
Успешный сценарий — юзкейс, при котором все идет по плану, без ошибок и неожиданностей.
Альтернативные пути — вариации основного успешного сценария на случай, если что-то пойдет не так на уровне системы.

![image](https://user-images.githubusercontent.com/105555106/198086381-8398a178-5dfa-4061-a034-d3c85e416681.png)
