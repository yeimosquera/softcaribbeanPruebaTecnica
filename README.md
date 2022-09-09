<!DOCTYPE html><html><body id="preview">
<h1 class="code-line" data-line-start=0 data-line-end=1><a id="Softcaribbean_Prueba_Tecnica_0"></a>Softcaribbean Prueba Tecnica</h1>
<p class="has-line-data" data-line-start="2" data-line-end="3"><img src="https://www.softcaribbean.com/wp-content/uploads/2021/08/logo-softcaribbean.png" alt="Alt text" title="Title"></p>
<h5 class="code-line" data-line-start=4 data-line-end=5><a id="Es_un_api_desarrollada_en_NET_Core_5_con_MySql__como_base_de_datos_y__Dapper_para_asignar_consultas_a_los_objetos_de_manera_simplificada_4"></a>Es un api desarrollada en .NET Core 5, con MySql como base de datos y Dapper para asignar consultas a los objetos de manera simplificada.</h5>
<h5 class="code-line" data-line-start=6 data-line-end=7><a id="Gracias_a_NET_File_Swagger_esta_incorporado_en_el_template_de_sta_versin_y_detecta_la_creacin_de_Apis_generando_la_documentacin_pertinente_de_la_misma_6"></a>Gracias a .NET File, Swagger esta incorporado en el template de ésta versión y detecta la creación de Apis generando la documentación pertinente de la misma:</h5>
<p class="has-line-data" data-line-start="7" data-line-end="8"><img src="https://addons.mozilla.org/user-media/previews/full/192/192679.png?modified=1622132852" alt="Alt text" title="Title"></p>
<h5 class="code-line" data-line-start=9 data-line-end=10><a id="Todas_lavalidaciones_estan_personalizadas_con_validation_attributes_que_me_sirve_para_validacin_del_modelo_se_producen_antes_de_la_ejecucin_de_una_accin_de_controlador_9"></a>Todas lavalidaciones estan personalizadas con validation attributes que me sirve para validación del modelo, se producen antes de la ejecución de una acción de controlador.</h5>
<h1 class="code-line" data-line-start=12 data-line-end=13><a id="Qu_es_Dapper_12"></a>¿Qué es Dapper?</h1>
<p class="has-line-data" data-line-start="13" data-line-end="14">Dapper es una popular herramienta de mapeo de objetos simples. Está diseñado principalmente para usarse en escenarios en los que desea trabajar con datos fuertemente tipados, como objetos comerciales en una aplicación .NET, pero no desea pasar horas escribiendo código para mapear resultados de consultas de datos <a href="http://ADO.NET">ADO.NET</a>. lectores a instancias de esos objetos. Dapper es un proyecto de código abierto bajo la licencia Apache . Está disponible como paquete Nuget y se ha descargado más de 16 millones de veces.</p>
<h2 class="code-line" data-line-start=15 data-line-end=16><a id="Tech_15"></a>Tech</h2>
<p class="has-line-data" data-line-start="17" data-line-end="18">Dillinger uses a number of open source projects to work properly:</p>
<ul>
<li class="has-line-data" data-line-start="19" data-line-end="20"><a href="http://angularjs.org">AngularJS</a> - HTML enhanced for web apps!</li>
<li class="has-line-data" data-line-start="20" data-line-end="21"><a href="http://ace.ajax.org">Ace Editor</a> - awesome web-based text editor</li>
<li class="has-line-data" data-line-start="21" data-line-end="22"><a href="https://github.com/markdown-it/markdown-it">markdown-it</a> - Markdown parser done right. Fast and easy to extend.</li>
<li class="has-line-data" data-line-start="22" data-line-end="23"><a href="https://twitter.github.com/bootstrap/">Twitter Bootstrap</a> - great UI boilerplate for modern web apps</li>
<li class="has-line-data" data-line-start="23" data-line-end="24"><a href="https://nodejs.org">node.js</a> - evented I/O for the backend</li>
<li class="has-line-data" data-line-start="24" data-line-end="25"><a href="https://expressjs.com">Express</a> - fast node.js network app framework <a href="https://twitter.com/tjholowaychuk">@tjholowaychuk</a></li>
<li class="has-line-data" data-line-start="25" data-line-end="26"><a href="http://gulpjs.com">Gulp</a> - the streaming build system</li>
<li class="has-line-data" data-line-start="26" data-line-end="28"><a href="https://breakdance.github.io/breakdance/">Breakdance</a> - HTML<br>
to Markdown converter</li>
<li class="has-line-data" data-line-start="28" data-line-end="30"><a href="https://jquery.com">jQuery</a> - duh</li>
</ul>
<p class="has-line-data" data-line-start="30" data-line-end="32">And of course Dillinger itself is open source with a <a href="https://github.com/joemccann/dillinger">public repository</a><br>
on GitHub.</p>
<h2 class="code-line" data-line-start=33 data-line-end=34><a id="Installation_33"></a>Installation</h2>
<p class="has-line-data" data-line-start="35" data-line-end="36">Dillinger requires <a href="https://nodejs.org/">Node.js</a> v10+ to run.</p>
<p class="has-line-data" data-line-start="37" data-line-end="38">Install the dependencies and devDependencies and start the server.</p>
<pre><code class="has-line-data" data-line-start="40" data-line-end="44" class="language-sh"><span class="hljs-built_in">cd</span> dillinger
npm i
node app
</code></pre>
<p class="has-line-data" data-line-start="45" data-line-end="46">For production environments…</p>
<pre><code class="has-line-data" data-line-start="48" data-line-end="51" class="language-sh">npm install --production
NODE_ENV=production node app
</code></pre>
<h2 class="code-line" data-line-start=52 data-line-end=53><a id="Plugins_52"></a>Plugins</h2>
<p class="has-line-data" data-line-start="54" data-line-end="56">Dillinger is currently extended with the following plugins.<br>
Instructions on how to use them in your own application are linked below.</p>
<table class="table table-striped table-bordered">
<thead>
<tr>
<th>Plugin</th>
<th>README</th>
</tr>
</thead>
<tbody>
<tr>
<td>Dropbox</td>
<td><a href="https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md">plugins/dropbox/README.md</a></td>
</tr>
<tr>
<td>GitHub</td>
<td><a href="https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md">plugins/github/README.md</a></td>
</tr>
<tr>
<td>Google Drive</td>
<td><a href="https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md">plugins/googledrive/README.md</a></td>
</tr>
<tr>
<td>OneDrive</td>
<td><a href="https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md">plugins/onedrive/README.md</a></td>
</tr>
<tr>
<td>Medium</td>
<td><a href="https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md">plugins/medium/README.md</a></td>
</tr>
<tr>
<td>Google Analytics</td>
<td><a href="https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md">plugins/googleanalytics/README.md</a></td>
</tr>
</tbody>
</table>
<h2 class="code-line" data-line-start=66 data-line-end=67><a id="Development_66"></a>Development</h2>
<p class="has-line-data" data-line-start="68" data-line-end="69">Want to contribute? Great!</p>
<p class="has-line-data" data-line-start="70" data-line-end="72">Dillinger uses Gulp + Webpack for fast developing.<br>
Make a change in your file and instantaneously see your updates!</p>
<p class="has-line-data" data-line-start="73" data-line-end="74">Open your favorite Terminal and run these commands.</p>
<p class="has-line-data" data-line-start="75" data-line-end="76">First Tab:</p>
<pre><code class="has-line-data" data-line-start="78" data-line-end="80" class="language-sh">node app
</code></pre>
<p class="has-line-data" data-line-start="81" data-line-end="82">Second Tab:</p>
<pre><code class="has-line-data" data-line-start="84" data-line-end="86" class="language-sh">gulp watch
</code></pre>
<p class="has-line-data" data-line-start="87" data-line-end="88">(optional) Third:</p>
<pre><code class="has-line-data" data-line-start="90" data-line-end="92" class="language-sh">karma <span class="hljs-built_in">test</span>
</code></pre>
<h4 class="code-line" data-line-start=93 data-line-end=94><a id="Building_for_source_93"></a>Building for source</h4>
<p class="has-line-data" data-line-start="95" data-line-end="96">For production release:</p>
<pre><code class="has-line-data" data-line-start="98" data-line-end="100" class="language-sh">gulp build --prod
</code></pre>
<p class="has-line-data" data-line-start="101" data-line-end="102">Generating pre-built zip archives for distribution:</p>
<pre><code class="has-line-data" data-line-start="104" data-line-end="106" class="language-sh">gulp build dist --prod
</code></pre>
<h2 class="code-line" data-line-start=107 data-line-end=108><a id="Docker_107"></a>Docker</h2>
<p class="has-line-data" data-line-start="109" data-line-end="110">Dillinger is very easy to install and deploy in a Docker container.</p>
<p class="has-line-data" data-line-start="111" data-line-end="114">By default, the Docker will expose port 8080, so change this within the<br>
Dockerfile if necessary. When ready, simply use the Dockerfile to<br>
build the image.</p>
<pre><code class="has-line-data" data-line-start="116" data-line-end="119" class="language-sh"><span class="hljs-built_in">cd</span> dillinger
docker build -t &lt;youruser&gt;/dillinger:<span class="hljs-variable">${package.json.version}</span> .
</code></pre>
<p class="has-line-data" data-line-start="120" data-line-end="123">This will create the dillinger image and pull in the necessary dependencies.<br>
Be sure to swap out <code>${package.json.version}</code> with the actual<br>
version of Dillinger.</p>
<p class="has-line-data" data-line-start="124" data-line-end="127">Once done, run the Docker image and map the port to whatever you wish on<br>
your host. In this example, we simply map port 8000 of the host to<br>
port 8080 of the Docker (or whatever port was exposed in the Dockerfile):</p>
<pre><code class="has-line-data" data-line-start="129" data-line-end="131" class="language-sh">docker run <span class="hljs-operator">-d</span> -p <span class="hljs-number">8000</span>:<span class="hljs-number">8080</span> --restart=always --cap-add=SYS_ADMIN --name=dillinger &lt;youruser&gt;/dillinger:<span class="hljs-variable">${package.json.version}</span>
</code></pre>
<blockquote>
<p class="has-line-data" data-line-start="132" data-line-end="133">Note: <code>--capt-add=SYS-ADMIN</code> is required for PDF rendering.</p>
</blockquote>
<p class="has-line-data" data-line-start="134" data-line-end="136">Verify the deployment by navigating to your server address in<br>
your preferred browser.</p>
<pre><code class="has-line-data" data-line-start="138" data-line-end="140" class="language-sh"><span class="hljs-number">127.0</span>.<span class="hljs-number">0.1</span>:<span class="hljs-number">8000</span>
</code></pre>
<h2 class="code-line" data-line-start=141 data-line-end=142><a id="License_141"></a>License</h2>
<p class="has-line-data" data-line-start="143" data-line-end="144">MIT</p>
<p class="has-line-data" data-line-start="145" data-line-end="146"><strong>Free Software, Hell Yeah!</strong></p>
</body></html>
