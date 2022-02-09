<template>
  <div class="game">
    <h1>game stuff </h1>
      <div id="p5Canvas"/>
  </div>
</template>

<script>
export default {
  name: 'GameRoot',
  mounted: function () {
    var radar = require('../../scripts/p5/Radar.js')
    const P5 = require('p5');
    new P5(radar.main);
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>