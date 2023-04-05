<h1>Bellman-Ford-Algoritms</h1>
bellman ford algoritmasının  örneklenerek nasıl çalıştığının örnek kodudur.

Tek kaynaklı en kısa yol problemini çözmek için kullanılan bir algoritmadır.
bir ağ üzerinde, bir kaynak düğümden diğer tüm hedef düğümlere olan en kısa yolları bulmak için kullanılır.
Bu algoritmanın çalışma zamanı, grafın yapısına ve algoritmanın uygulanacağı yönteme bağlıdır.

<h2>Ne için kullanılır</h2>
Bu algoritma, özellikle dağıtık sistemler, yönlendirme protokolleri ve trafik yönetimi gibi alanlarda yaygın olarak kullanılır.
Örneğin, internet protokolü (IP) yönlendirme tablolarının oluşturulmasında ve kablosuz ağlarda yönlendirme protokollerinde kullanılır.
Ayrıca, Bellman-Ford algoritması, negatif ağırlıklı kenarlara sahip grafiklerde de kullanılabilir 
ve bu nedenle diğer en kısa yol algoritmalarının kullanılamadığı durumlarda tercih edilebilir.

<h2>Çalışma zamanı</h2>
<p>
Bellman-Ford algoritmasının çalışma zamanı, genellikle O(V * E) olarak ifade edilir,
burada V düğüm sayısını ve E kenar sayısını temsil eder.

<h3>En iyi</h3>
grafın hiçbir negatif ağırlıklı döngüsü olmadığında elde edilir.
Bu durumda, algoritma, tüm düğümlere tek seferde ulaşabilecekleri en kısa yolu bulmak için sadece V-1 kez kenarları tarar.
E kenar sayısı, grafın seyrekliğine bağlı olarak V'den çok daha küçük olabilir 
ve bu nedenle en iyi durumda Bellman-Ford algoritmasının çalışma zamanı O(V^2) olarak da ifade edilebilir.


<h3>En kötü</h3>
Bu zaman karmaşıklığı, algoritmanın her düğüm için en fazla E kez dönebileceği ve her döngüde tüm kenarların taranması gerektiği gerçeğinden kaynaklanır.
En kötü durumda, algoritma, grafın tamamını taramak zorunda kalabilir, bu da O(V * E) zaman karmaşıklığına neden olur.

<h3>Ortalama</h3>
Bellman-Ford algoritmasının ortalama durum karmaşıklığı, genellikle grafın yoğunluğuna ve özelliklerine bağlı olarak değişebilir.
Ancak, graf seyrekse O(V E log V) sınırları içinde çalışabilirken, yoğun grafiklerde O(V^3) sınırlarında çalışabilir.

</p>

