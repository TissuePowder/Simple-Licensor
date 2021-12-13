const Sequelize = require('sequelize');

const db = new Sequelize('simple-licensor', 'admin', '12345', {
    host: 'localhost',
    dialect: 'postgres'
  });

module.exports = db
