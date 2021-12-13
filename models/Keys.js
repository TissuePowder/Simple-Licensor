const Sequelize = require('sequelize');
const db = require('../config/database')

const Keys = db.define('keys', {
	id: {
		type: Sequelize.INTEGER,
		primaryKey: true,
		autoIncrement: true,
	},
	key: {
		type: Sequelize.STRING,
		allowNull: false,
	},
	type: {
		type: Sequelize.STRING,
		allowNull: false,
	},
	duration: {
		type: Sequelize.STRING,
		allowNull: false,
	},
	activatedAt: {
		type: Sequelize.DATE,
	},
    condition: {
		type: Sequelize.STRING,
        allowNull: false,
	},

});

module.exports = Keys;
