$(function(){

	var yearSeleccionado = {};
	var owner = {};
	var cardNumber = {};
	var cardNumberField = {};
	var cvv = {};
	var mastercard = {};
	var visa = {};
	var amex = {};
	var confirmarButton = {};

	const ini = () => {
		yearSeleccionado = $('#yearSeleccionado');
		cardNumberField = $('#card-number-field');
		owner = $('#owner');
		cardNumber = $('#cardNumber');
		cvv = $('#cvv');
		mastercard = $('#mastercard');
		visa = $('#visa');
		amex = $('#amex');
		confirmarButton = $('#confirm-purchase');
		cargarAnios();
		carNumber.payform('formatCardNumber');
		CVV.payform('formatCardCVC');
		bind();
	}

	const bind = () => {
		cardNumber.keyup = validPlacements;
		confirmarButton.on('click',accionValidar);
	}

	const validarNumber = () => {
		console.log('vamos bien');
	}

	const accionValidar = () => {
		consoe.log('click');
	}

	const cargarAnios = () => {
		let anio = new Date().getFullYear();
		for (var index = 0; index < 10; index++) {
			anio+= index;
			yearSeleccionado.append(new Option(value, value.toString().substr(-2)));
		}
	}

	ini();
});