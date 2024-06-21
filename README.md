# FullStackBootcampOdevler
Ödev 1:  SOLID prensiplerinin her birini uygulamak için her prensibi ayrı bir sınıf içinde gerçekleştiriniz.

SOLID prensipleri, yazılım geliştirme sürecinde daha esnek, genişletilebilir ve bakım yapılabilir kodlar yazmak için beş temel prensibi içerir. Bu prensipler:

S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
O - Open/Closed Principle (Açık/Kapalı Prensibi)
L - Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
D - Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)

 Ödev 2:  Delegate ve Event Kullanımı ile ilgili 3 farklı örnek senaryo gerçekleştirin.

Senaryo 1: E-Ticaret Sistemi

Açıklama:
Bir e-ticaret sistemi, müşterilerin alışveriş yapmasına ve sipariş vermesine olanak tanır. Bu sistemde, sipariş tamamlandığında müşteriye ve ilgili departmanlara bilgi vermek için event ve delegate kullanılabilir.

Delegate ve Event Kullanımı:
Bir delegate tanımlanır ve sipariş tamamlandığında tetiklenecek event için kullanılır.
Müşteri hizmetleri departmanı, siparişin tamamlandığını bildiren bir e-posta göndermek için bu event'e abone olur.
Depo yönetim sistemi, stoktan düşülmesi gereken ürünleri güncellemek için aynı event'e abone olur.
Muhasebe departmanı, fatura oluşturmak için bu event'e abone olur.


Senaryo 2: Oyun Geliştirme
Açıklama:
Bir oyun geliştirme projesinde, oyun içerisindeki karakterlerin belirli olaylara tepki vermesi gerekmektedir. Örneğin, bir karakterin canı belirli bir seviyenin altına düştüğünde veya bir düşman öldüğünde bu olaylara tepki vermek için event ve delegate kullanılabilir.


Senaryo 3: Finansal Uygulama
Açıklama:
Bir finansal uygulama, kullanıcıların hesap hareketlerini izlemesine ve belirli finansal olaylardan haberdar olmasına olanak tanır. Örneğin, belirli bir tutarın üzerinde bir işlem gerçekleştirildiğinde veya bir hesapta belirli bir limitin altına düşüldüğünde bu olaylar için event ve delegate kullanılabilir.


 Tüm array/collection tipleri ile ilgili her biri ayrı bir class'ta olmak üzere örnek gerçekleştirin.

Array Tipleri

Array

System.Collections Namespace

ArrayList
Hashtable
Queue
Stack
System.Collections.Generic Namespace

List<T>
Dictionary<TKey, TValue>
SortedList<TKey, TValue>
Queue<T>
Stack<T>
HashSet<T>
LinkedList<T>
