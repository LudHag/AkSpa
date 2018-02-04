﻿var webpack = require('webpack');
var path = require('path');

// Naming and path settings
var appName = 'app';
var entryPoint = './App/main.js';
var exportPath = path.resolve(__dirname, './wwwroot/dist');

// Enviroment flag
var plugins = [];
var env = process.env.NODE_ENV;

// Differ settings based on production flag
if (env === 'production') {
    plugins.push(new webpack.DefinePlugin({
            'process.env': {
                NODE_ENV: '"production"'
            }
        }
    ));

    appName = appName + '.js';
} else {
    appName = appName + '.js';
}

// Main Settings config
module.exports = {
    entry: { main: entryPoint },
    output: {
        path: exportPath,
        filename: appName,
        publicPath: '/dist'
    },
    module: {
        loaders: [
            {
                test: /\.(js|vue)$/,
                exclude: /(node_modules|bower_components)/,
                loader: 'babel-loader',
                query: {
                    presets: ['es2015']
                }
            },
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            }
        ]
    },
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm.js'
        },
        extensions: ['*', '.js', '.vue']
    },
    plugins
};