// const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
  // productionSourceMap: false,
  // publicPath: process.env.NODE_ENV === 'production' ? '/v1' : '/v1',
  outputDir: '../wwwroot/',
  //indexPath: 'index.html'

  /*
  chainWebpack: config => {
    config.module.rule('js').exclude.add(/\.worker\.js$/)

    config.module
      .rule('worker-loader')
      .test(/\.worker\.js$/)
      .use('worker-loader')
      .loader('worker-loader')

    config.module.rule('eslint').use('eslint-loader').options({
      fix: true
    })
  },
  devServer: {
    https: false
  },
  configureWebpack: {
    devtool: 'source-map'

  },
  filenameHashing: false,

  */
}
