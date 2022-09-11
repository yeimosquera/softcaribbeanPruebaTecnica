<!DOCTYPE html><html><body id="preview">
<h1 class="code-line" data-line-start=0 data-line-end=1><a id="Softcaribbean_Prueba_Tecnica_0"></a>Softcaribbean Prueba Tecnica</h1>
<p class="has-line-data" data-line-start="2" data-line-end="3"><img src="https://www.softcaribbean.com/wp-content/uploads/2021/08/logo-softcaribbean.png" alt="Alt text" title="Title"></p>
<h5 class="code-line" data-line-start=4 data-line-end=5><a id="Es_un_api_desarrollada_en_NET_Core_5_con_MySql__como_base_de_datos_y__Dapper_para_asignar_consultas_a_los_objetos_de_manera_simplificada_4"></a>Es un api desarrollada en .NET Core 5, con MySql como base de datos y Dapper para asignar consultas a los objetos de manera simplificada; Tiene todo el tema de pruebas unitarias con UnitTesting complementado Moq y AutoFixture.
Parra probar el api integrada con el front creamo un tunel de Ngrok.
</h5>
<h5 class="code-line" data-line-start=6 data-line-end=7><a id="Gracias_a_NET_File_Swagger_esta_incorporado_en_el_template_de_sta_versin_y_detecta_la_creacin_de_Apis_generando_la_documentacin_pertinente_de_la_misma_6"></a>Gracias a .NET File, Swagger esta incorporado en el template de ésta versión y detecta la creación de Apis generando la documentación pertinente de la misma:</h5>
<p class="has-line-data" data-line-start="7" data-line-end="8"><img src="https://addons.mozilla.org/user-media/previews/full/192/192679.png?modified=1622132852" alt="Alt text" title="Title"></p>
<h5 class="code-line" data-line-start=9 data-line-end=10><a id="Todas_lavalidaciones_estan_personalizadas_con_validation_attributes_que_me_sirve_para_validacin_del_modelo_se_producen_antes_de_la_ejecucin_de_una_accin_de_controlador_9"></a>Todas lavalidaciones estan personalizadas con validation attributes que me sirve para validación del modelo, se producen antes de la ejecución de una acción de controlador.</h5>
<h1 class="code-line" data-line-start=12 data-line-end=13><a id="Qu_es_Dapper_12"></a>¿Qué es Dapper?</h1>
<p class="has-line-data" data-line-start="13" data-line-end="14">Dapper es una popular herramienta de mapeo de objetos simples. Está diseñado principalmente para usarse en escenarios en los que desea trabajar con datos fuertemente tipados, como objetos comerciales en una aplicación .NET, pero no desea pasar horas escribiendo código para mapear resultados de consultas de datos <a href="http://ADO.NET">ADO.NET</a>. lectores a instancias de esos objetos. Dapper es un proyecto de código abierto bajo la licencia Apache . Está disponible como paquete Nuget y se ha descargado más de 16 millones de veces.</p>


<h2 class="code-line" data-line-start=52 data-line-end=53><a id="Plugins_52"></a>Plugins</h2>
<p class="has-line-data" data-line-start="54" data-line-end="56">Para el desarrollo de la de la solución fueron necesarios los siguientes plugin: </p>
<table class="table table-striped table-bordered">
<thead>
<tr>
<th>Plugin</th>
<th>Descripción</th>
</tr>
</thead>
<tbody>
<tr>
<td>Dapper</td>
<td>Herramienta de mapeo de objetos simples</td>
</tr>
<tr>
<td>Moq</td>
<td>Simulación de la interfaz para pruebas unitarias</td>
</tr>
<tr>
<td>Autofixture</td>
<td>Para generar datos de prueba y no cascarle a la db en el controlador de Test</td>
</tr>
<tr>
<td>MySql</td>
<td>Para base de datos</td>
</tr>
</tbody>
</table>

</body></html>
