<template>
  <div class="container">
    <a :href=path>
      <img :src=image>
      {{description}}
    </a>
  </div>
</template>


<script>
export default{
  name: 'SocialLink',
  props:{
    description:{
      type: String,
      required: true
    },
    imageUrl:{
      type: String,
      required: true
    },
    path:{
      type: String,
      required: true
    }
  },
    data: function () {
    return {
      image: require(props.imageUrl)
    }
  }
}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .container{
    padding: 0.5em 0.5em;
  }
</style>