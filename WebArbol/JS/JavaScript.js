function conectar(arbolJson) {
    var arbol = JSON.parse(arbolJson);
    dibujarCanvas(arbol);
}

function dibujarNodo(ctx, nodo, x, y, offsetX) {
    if (!nodo) return;

    // Dibujar nodo actual
    ctx.beginPath();
    ctx.arc(x, y, 25, 0, 2 * Math.PI);
    ctx.fillStyle = 'white';
    ctx.fill();
    ctx.strokeStyle = '#038C3E'; // verde
    ctx.stroke();
    ctx.font = '15px Arial';
    ctx.fillStyle = 'black';
    ctx.textAlign = 'center';
    ctx.textBaseline = 'middle';
    ctx.fillText(nodo.dato.Valor, x, y);

    // Calcular posiciones para los hijos
    let childY = y + 100;
    let childOffsetX = offsetX / 2;

    // Dibujar conexiones y nodos hijos recursivamente
    if (nodo.Izquierda) {
        let childX = x - offsetX;
        ctx.beginPath();
        ctx.moveTo(x, y + 25);
        ctx.lineTo(childX, childY - 25);
        ctx.strokeStyle = '#8C503A'; // Café
        ctx.stroke();
        dibujarNodo(ctx, nodo.Izquierda, childX, childY, childOffsetX);
    }

    if (nodo.Derecha) {
        let childX = x + offsetX;
        ctx.beginPath();
        ctx.moveTo(x, y + 25);
        ctx.lineTo(childX, childY - 25);
        ctx.strokeStyle = '#8C503A'; // Café
        ctx.stroke();
        dibujarNodo(ctx, nodo.Derecha, childX, childY, childOffsetX);
    }
}

function dibujarCanvas(arbol) {
    var canvas = document.getElementById("miCanvas");
    var ctx = canvas.getContext('2d');

    // Limpiar el canvas
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Llamar a la función para dibujar el árbol
    dibujarNodo(ctx, arbol.raiz, 500, 50, 250);
}
