<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Perfil Personal</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
            color: #333;
        }
        .container {
            width: 80%;
            margin: auto;
            overflow: hidden;
        }
        header {
            background: #333;
            color: #fff;
            padding-top: 30px;
            min-height: 70px;
            border-bottom: #fff 3px solid;
            text-align: center;
        }
        header h1 {
            margin: 0;
            font-size: 2em;
        }
        img {
            max-width: 150px;
            border-radius: 50%;
            display: block;
            margin: 0 auto;
        }
        .content {
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            margin-top: 20px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }
        table, th, td {
            border: 1px solid #ddd;
        }
        th, td {
            padding: 8px;
            text-align: left;
        }
        th {
            background: #f4f4f4;
        }
        h2 {
            border-bottom: 2px solid #333;
            padding-bottom: 10px;
        }
    </style>
</head>
<body>
    <header>
        <h1>Perfil Personal</h1>
    </header>

    <div class="container">
        <div class="content">
            <img src="lucas.jpeg" alt="Girl in a jacket">
            <h2>Información Personal</h2>
            <p><strong>Nombre:</strong> Antonio Lucas</p>
            <p><strong>Edad:</strong> 40 años</p>
            <p><strong>Ciudad de residencia:</strong> Santo Domingo</p>
            <p><strong>Título de bachiller o tercer nivel:</strong> Tecnología de la Información</p>

            <h2>Pasatiempos Favoritos</h2>
            <table>
                <thead>
                    <tr>
                        <th>Pasatiempo</th>
                        <th>Descripción</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Lectura</td>
                        <td>Disfruto leer libros de diversos géneros.</td>
                    </tr>
                    <tr>
                        <td>Cine</td>
                        <td>Me gusta ver películas de diferentes géneros.</td>
                    </tr>
                    <tr>
                        <td>Jardinería</td>
                        <td>Cuidar y cultivar plantas es muy relajante para mí.</td>
                    </tr>
                </tbody>
            </table>

            <h2>Deportes Favoritos</h2>
            <table>
                <thead>
                    <tr>
                        <th>Deporte</th>
                        <th>Descripción</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Fútbol</td>
                        <td>Me encanta jugar y seguir partidos de fútbol.</td>
                    </tr>
                    <tr>
                        <td>Natación</td>
                        <td>Me gusta nadar para mantenerme en forma.</td>
                    </tr>
                    <tr>
                        <td>Ciclismo</td>
                        <td>Disfruto de los paseos en bicicleta durante el fin de semana.</td>
                    </tr>
                </tbody>
            </table>

            <h2>Expectativa de la Profesión</h2>
            <p>Espero que la carrera en Tecnología de la Información me permita adquirir habilidades avanzadas en el campo de la tecnología y la informática. Estoy emocionado por la oportunidad de trabajar en proyectos innovadores y contribuir con soluciones tecnológicas efectivas. Mi meta es avanzar profesionalmente y participar en el desarrollo de tecnologías que mejoren la vida cotidiana.</p>
        </div>
    </div>
</body>
</html>
